using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenVkNetApi.Events;
using OpenVkNetApi.Models.Messages;

namespace OpenVkNetApi.Services
{
    /// <summary>
    /// Service for managing OpenVK Long Poll connection and dispatching events.
    /// Implements <see cref="IDisposable"/> to ensure proper cleanup of resources.
    /// </summary>
    public sealed class LongPollService : IDisposable
    {
        private readonly OpenVkApi _api;
        private readonly HttpClient _http;

        private LongPollServerInfo _lp;
        private CancellationTokenSource _internalCts;

        private readonly HashSet<long> _recentIds = new HashSet<long>();
        private const int MAX_CACHE = 1000;

        private bool _running;

        private int _wait = 25;
        private int _mode = 234;
        private readonly int _version = 3;

        /// <summary>
        /// Gets or sets the bitmask mode for Long Poll requests (default: 234 = attachments + extended + pts + extra platform + random_id).
        /// </summary>
        public int Mode
        {
            get => _mode;
            set => _mode = value;
        }

        /// <summary>
        /// Occurs when a new message is received via Long Poll.
        /// </summary>
        public event EventHandler<NewMessageEventArgs> OnMessageNew;

        /// <summary>
        /// Occurs when an existing message is edited.
        /// </summary>
        public event EventHandler<MessageEditEventArgs> OnMessageEdit;

        /// <summary>
        /// Occurs when messages in a conversation are marked as read.
        /// </summary>
        public event EventHandler<MessagesReadEventArgs> OnMessagesRead;

        /// <summary>
        /// Occurs when a friend/user comes online.
        /// </summary>
        public event EventHandler<UserOnlineEventArgs> OnUserOnline;

        /// <summary>
        /// Occurs when a friend/user goes offline.
        /// </summary>
        public event EventHandler<UserOfflineEventArgs> OnUserOffline;

        /// <summary>
        /// Occurs when chat information or settings change.
        /// </summary>
        public event EventHandler<ChatChangeEventArgs> OnChatChanged;

        /// <summary>
        /// Occurs when the total unread messages counter is updated.
        /// </summary>
        public event EventHandler<UnreadCountEventArgs> OnUnreadCountChanged;

        /// <summary>
        /// Occurs when a user starts typing a message or recording an audio message in a conversation.
        /// </summary>
        public event EventHandler<UserTypingEventArgs> OnUserTyping;

        /// <summary>
        /// Occurs when an error is encountered during the Long Poll process.
        /// </summary>
        public event EventHandler<LongPollErrorEventArgs> OnError;

        /// <summary>
        /// Initializes a new instance of the <see cref="LongPollService"/> class.
        /// </summary>
        /// <param name="api">The OpenVkApi instance to use for API calls.</param>
        /// <param name="client">An optional custom <see cref="HttpClient"/> instance to use. If null, a new one is created.</param>
        public LongPollService(OpenVkApi api, HttpClient client = null)
        {
            _api = api;
            _http = client ?? new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(70) // > wait
            };

            try
            {
                _http.DefaultRequestHeaders.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue
                {
                    NoCache = true,
                    NoStore = true
                };
                _http.DefaultRequestHeaders.IfModifiedSince = DateTimeOffset.UtcNow;
            }
            catch { }
        }

        /// <summary>
        /// Starts listening for Long Poll events asynchronously.
        /// Can be called safely multiple times; subsequent calls while running will be ignored.
        /// </summary>
        /// <param name="externalCt">An optional external <see cref="CancellationToken"/> to cancel the listening process.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        /// <exception cref="Exception">Thrown if initial Long Poll server information cannot be obtained.</exception>
        public async Task StartAsync(CancellationToken externalCt = default)
        {
            if (_running) return;

            _running = true;
            _internalCts = CancellationTokenSource.CreateLinkedTokenSource(externalCt);
            var ct = _internalCts.Token;

            try
            {
                if (!await RefreshServerAsync(ct))
                    throw new Exception("Failed to get LongPoll server.");

                await PollLoopAsync(ct);
            }
            finally
            {
                _running = false;
            }
        }

        /// <summary>
        /// Stops the Long Poll listening process.
        /// </summary>
        public void Stop()
        {
            if (!_running) return;
            _internalCts?.Cancel();
        }

        /// <summary>
        /// The main asynchronous loop for polling the Long Poll server.
        /// </summary>
        /// <param name="ct">The cancellation token to observe.</param>
        private async Task PollLoopAsync(CancellationToken ct)
        {
            int retryDelay = 1000;

            while (!ct.IsCancellationRequested)
            {
                try
                {
                    if (_lp == null)
                    {
                        bool ok = await RefreshServerAsync(ct);
                        if (!ok)
                        {
                            await Task.Delay(retryDelay, ct);
                            retryDelay = Math.Min(retryDelay + 1000, 10000);
                            continue;
                        }
                    }

                    string server = SanitizeServerUrl(_lp.Server);
                    string sep = server.Contains("?") ? "&" : "?";
                    string url =
                        $"{server}" +
                        $"{sep}act=a_check" +
                        $"&key={_lp.Key}" +
                        $"&ts={_lp.Ts}" +
                        $"&wait={_wait}" +
                        $"&mode={_mode}" +
                        $"&version={_version}";

                    System.Diagnostics.Debug.WriteLine("[LongPoll] Polling URL: " + url);

                    var sw = System.Diagnostics.Stopwatch.StartNew();
                    using (var resp = await _http.GetAsync(url, ct))
                    {
                        sw.Stop();
                        resp.EnsureSuccessStatusCode();

                        string json = await resp.Content.ReadAsStringAsync();

                        if (!string.IsNullOrWhiteSpace(json))
                        {
                            // If the request returns immediately (e.g. < 1s) and is a structured JSON (not []),
                            // discard it (server cache not expired), wait for wait_time seconds, and repeat (Step 5 of the rule)
                            if (sw.ElapsedMilliseconds < 1000 && json.TrimStart().StartsWith("{") && !json.Contains("\"failed\""))
                            {
                                System.Diagnostics.Debug.WriteLine(string.Format("[LongPoll] Returned immediately ({0}ms). Server cache not expired. Waiting {1}s...", sw.ElapsedMilliseconds, _wait));
                                await Task.Delay(_wait * 1000, ct);
                                continue;
                            }

                            await HandleResponseAsync(json, ct);
                        }

                        retryDelay = 1000; // if everything is ok, we reset the delay
                    }
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    OnError?.Invoke(this,
                        new LongPollErrorEventArgs("LongPoll request error", ex));

                    _lp = null;

                    await Task.Delay(retryDelay, ct);
                    retryDelay = Math.Min(retryDelay + 1000, 10000);
                }
            }
        }

        /// <summary>
        /// Handles the JSON response received from the Long Poll server.
        /// </summary>
        /// <param name="json">The raw JSON string from the server.</param>
        /// <param name="ct">The cancellation token to observe.</param>
        private async Task HandleResponseAsync(string json, CancellationToken ct)
        {
            if (json[0] == '{')
            {
                var lp = JsonConvert.DeserializeObject<RawLongPollResponse>(json);
                if (lp == null) return;

                if (lp.Failed != null)
                {
                    await HandleFailedAsync(lp.Failed.Value, lp.Ts, ct);
                    return;
                }

                _lp.Ts = lp.Ts;

                if (lp.Updates != null)
                    ProcessUpdates(lp.Updates);
            }
            else if (json[0] == '[')
            {
                var updates = JsonConvert.DeserializeObject<List<List<object>>>(json);
                if (updates != null)
                    ProcessUpdates(updates);

                await RefreshServerAsync(ct);
            }
        }

        /// <summary>
        /// Handles specific 'failed' error codes returned by the Long Poll server.
        /// </summary>
        /// <param name="code">The error code (e.g., 1, 2, 3).</param>
        /// <param name="newTs">The new 'ts' value provided by the server, if any.</param>
        /// <param name="ct">The cancellation token to observe.</param>
        private async Task HandleFailedAsync(int code, long newTs, CancellationToken ct)
        {
            switch (code)
            {
                case 1:
                    _lp.Ts = newTs;
                    break;

                case 2:
                case 3:
                    await RefreshServerAsync(ct);
                    break;

                default:
                    OnError?.Invoke(this,
                        new LongPollErrorEventArgs("Unknown failed code", null, code));
                    await RefreshServerAsync(ct);
                    break;
            }
        }

        /// <summary>
        /// Processes a list of raw Long Poll updates.
        /// </summary>
        /// <param name="updates">The list of raw updates (e.g., `[[4, ...], [4, ...]]`).</param>
        private void ProcessUpdates(List<List<object>> updates)
        {
            foreach (var u in updates)
            {
                if (u.Count == 0) continue;

                if (!int.TryParse(u[0]?.ToString(), out int type))
                    continue;

                switch (type)
                {
                    case 4:
                        ProcessNewMessage(u);
                        break;

                    case 5:
                        ProcessMessageEdit(u);
                        break;

                    case 6:
                        ProcessMessagesRead(u, isOutgoing: false);
                        break;

                    case 7:
                        ProcessMessagesRead(u, isOutgoing: true);
                        break;

                    case 8:
                        ProcessUserOnline(u);
                        break;

                    case 9:
                        ProcessUserOffline(u);
                        break;

                    case 51:
                        ProcessChatChangedUnknown(u);
                        break;

                    case 52:
                        ProcessChatChangedTyped(u);
                        break;

                    case 61:
                        ProcessUserTypingDm(u);
                        break;

                    case 62:
                        ProcessUserTypingChat(u);
                        break;

                    case 63:
                        ProcessUserActivityV3(u, isAudio: false);
                        break;

                    case 64:
                        ProcessUserActivityV3(u, isAudio: true);
                        break;

                    case 80:
                        ProcessUnreadCount(u);
                        break;
                }
            }
        }

        private void ProcessNewMessage(List<object> u)
        {
            long msgId = SafeLong(u, 1);
            if (msgId == 0) return;

            if (!_recentIds.Add(msgId))
                return;

            TrimCache();

            int flags = SafeInt(u, 2);
            long peerId = SafeLong(u, 3);
            long date = SafeLong(u, 4);

            string text = null;
            if (u.Count > 5 && u[5] is string s5 && !string.IsNullOrEmpty(s5))
            {
                text = s5;
            }
            else if (u.Count > 6 && u[6] is string s6)
            {
                text = s6;
            }

            long fromId = peerId;
            long cmid = 0;
            if (u.Count > 9)
            {
                cmid = SafeLong(u, 9);
            }

            if (peerId > 2000000000L)
            {
                long extracted = ExtractFromId(u);
                if (extracted != 0)
                {
                    fromId = extracted;
                }
            }

            var msg = new Message
            {
                Id = msgId,
                PeerId = peerId,
                FromId = fromId,
                Date = date,
                Text = text,
                ConversationMessageId = cmid > 0 ? cmid : (long?)null,
                Out = (flags & 2) != 0 ? 1 : 0,
                ReadState = (flags & 1) == 0 ? 1 : 0
            };

            OnMessageNew?.Invoke(this, new NewMessageEventArgs(msg));
        }

        private void ProcessMessageEdit(List<object> u)
        {
            long msgId = SafeLong(u, 1);
            int flags = SafeInt(u, 2);
            long peerId = SafeLong(u, 3);
            long date = SafeLong(u, 4);
            string text = u.Count > 5 ? u[5]?.ToString() : "";

            OnMessageEdit?.Invoke(this, new MessageEditEventArgs(msgId, peerId, text, date, flags));
        }

        private void ProcessMessagesRead(List<object> u, bool isOutgoing)
        {
            long peerId = SafeLong(u, 1);
            long localId = SafeLong(u, 2);

            OnMessagesRead?.Invoke(this, new MessagesReadEventArgs(peerId, localId, isOutgoing));
        }

        private void ProcessUserOnline(List<object> u)
        {
            long userId = Math.Abs(SafeLong(u, 1));
            int extra = SafeInt(u, 2);
            int platformId = extra & 0xFF;
            long timestamp = SafeLong(u, 3);

            OnUserOnline?.Invoke(this, new UserOnlineEventArgs(userId, platformId, timestamp));
        }

        private void ProcessUserOffline(List<object> u)
        {
            long userId = Math.Abs(SafeLong(u, 1));
            int flags = SafeInt(u, 2);
            long timestamp = SafeLong(u, 3);

            OnUserOffline?.Invoke(this, new UserOfflineEventArgs(userId, flags, timestamp));
        }

        private void ProcessChatChangedUnknown(List<object> u)
        {
            long chatId = SafeLong(u, 1);
            bool self = SafeInt(u, 2) == 1;

            OnChatChanged?.Invoke(this, new ChatChangeEventArgs(chatId, 2000000000L + chatId, 0, self));
        }

        private void ProcessChatChangedTyped(List<object> u)
        {
            int typeId = SafeInt(u, 1);
            long peerId = SafeLong(u, 2);
            long chatId = peerId > 2000000000L ? peerId - 2000000000L : peerId;

            OnChatChanged?.Invoke(this, new ChatChangeEventArgs(chatId, peerId, typeId, false));
        }

        private void ProcessUserTypingDm(List<object> u)
        {
            long userId = SafeLong(u, 1);
            if (userId > 0)
            {
                OnUserTyping?.Invoke(this, new UserTypingEventArgs(userId, userId, null, false));
            }
        }

        private void ProcessUserTypingChat(List<object> u)
        {
            long userId = SafeLong(u, 1);
            long chatId = SafeLong(u, 2);
            if (userId > 0 && chatId > 0)
            {
                long peerId = 2000000000L + chatId;
                OnUserTyping?.Invoke(this, new UserTypingEventArgs(userId, peerId, chatId, false));
            }
        }

        private void ProcessUserActivityV3(List<object> u, bool isAudio)
        {
            if (u.Count < 3) return;

            long peerId;
            var userIds = new List<long>();
            ExtractUsersAndPeer(u, out peerId, userIds);

            long? chatId = peerId > 2000000000L ? peerId - 2000000000L : (long?)null;
            foreach (var uid in userIds)
            {
                if (uid > 0)
                {
                    OnUserTyping?.Invoke(this, new UserTypingEventArgs(uid, peerId, chatId, isAudio));
                }
            }
        }

        private static void ExtractUsersAndPeer(List<object> u, out long peerId, List<long> userIds)
        {
            peerId = 0;
            if (u[1] is Newtonsoft.Json.Linq.JArray jArr1)
            {
                foreach (var item in jArr1)
                {
                    if (long.TryParse(item?.ToString(), out long id))
                        userIds.Add(id);
                }
                peerId = SafeLong(u, 2);
            }
            else if (u[2] is Newtonsoft.Json.Linq.JArray jArr2)
            {
                peerId = SafeLong(u, 1);
                foreach (var item in jArr2)
                {
                    if (long.TryParse(item?.ToString(), out long id))
                        userIds.Add(id);
                }
            }
            else
            {
                long id1 = SafeLong(u, 1);
                long id2 = SafeLong(u, 2);
                if (id2 > 2000000000L || id2 < 0)
                {
                    peerId = id2;
                    if (id1 > 0) userIds.Add(id1);
                }
                else
                {
                    peerId = id1;
                    if (id2 > 0) userIds.Add(id2);
                    else if (id1 > 0) userIds.Add(id1);
                }
            }
        }

        private void ProcessUnreadCount(List<object> u)
        {
            int count = SafeInt(u, 1);
            OnUnreadCountChanged?.Invoke(this, new UnreadCountEventArgs(count));
        }

        private static long ExtractFromId(List<object> u)
        {
            for (int i = 6; i <= 7 && i < u.Count; i++)
            {
                if (u[i] is Newtonsoft.Json.Linq.JObject jObj)
                {
                    if (jObj["from"] != null && long.TryParse(jObj["from"].ToString(), out long f))
                        return f;
                }
                else if (u[i] is IDictionary<string, object> dict)
                {
                    if (dict.TryGetValue("from", out var fVal) && long.TryParse(fVal?.ToString(), out long f))
                        return f;
                }
            }
            return 0;
        }

        /// <summary>
        /// Safely attempts to convert an element from the update list to an integer.
        /// </summary>
        /// <param name="a">The list of update elements.</param>
        /// <param name="i">The index of the element to convert.</param>
        /// <returns>The integer value if successful, otherwise 0.</returns>
        private static int SafeInt(List<object> a, int i)
            => a.Count > i && int.TryParse(a[i]?.ToString(), out var v) ? v : 0;

        /// <summary>
        /// Safely attempts to convert an element from the update list to a long integer.
        /// </summary>
        /// <param name="a">The list of update elements.</param>
        /// <param name="i">The index of the element to convert.</param>
        /// <returns>The long integer value if successful, otherwise 0.</returns>
        private static long SafeLong(List<object> a, int i)
            => a.Count > i && long.TryParse(a[i]?.ToString(), out var v) ? v : 0;

        /// <summary>
        /// Manages the size of the message ID cache, trimming older entries.
        /// </summary>
        private void TrimCache()
        {
            if (_recentIds.Count <= MAX_CACHE) return;

            var e = _recentIds.GetEnumerator();
            for (int i = 0; i < MAX_CACHE / 2 && e.MoveNext(); i++)
                _recentIds.Remove(e.Current);
        }

        /// <summary>
        /// Asynchronously obtains or refreshes the Long Poll server connection information.
        /// </summary>
        /// <param name="ct">The cancellation token to observe.</param>
        /// <returns><see langword="true"/> if server info was successfully obtained; otherwise, <see langword="false"/>.</returns>
        private async Task<bool> RefreshServerAsync(CancellationToken ct)
        {
            _lp = null;
            try
            {
                _lp = await _api.Messages
                    .GetLongPollServerAsync(1, _version, null, ct);

                if (_lp != null && !string.IsNullOrEmpty(_lp.Server))
                {
                    _lp.Server = SanitizeServerUrl(_lp.Server);
                }

                return _lp != null;
            }
            catch (Exception ex)
            {
                OnError?.Invoke(this,
                    new LongPollErrorEventArgs("GetLongPollServer failed", ex));

                await Task.Delay(1500, ct);
                return false;
            }
        }

        /// <summary>
        /// Ensures that the Long Poll server URL has an absolute HTTP or HTTPS scheme.
        /// </summary>
        /// <param name="server">The raw server URL returned by the API.</param>
        /// <returns>A well-formed absolute URL string.</returns>
        private string SanitizeServerUrl(string server)
        {
            if (string.IsNullOrEmpty(server))
                return server;

            server = server.Trim();
            string defaultScheme = (!string.IsNullOrEmpty(_api.BaseUrl) && _api.BaseUrl.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
                ? "http:"
                : "https:";

            if (server.StartsWith("//"))
            {
                return defaultScheme + server;
            }

            if (!server.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !server.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                return defaultScheme + "//" + server;
            }

            return server;
        }

        /// <summary>
        /// Sets the Long Poll wait time for server responses.
        /// </summary>
        /// <param name="seconds">The number of seconds to wait. Clamped between 0 and 60 seconds.</param>
        public void SetWait(int seconds)
            => _wait = Math.Max(0, Math.Min(60, seconds));

        /// <summary>
        /// Sets the Long Poll bitmask mode for additional event fields.
        /// </summary>
        /// <param name="mode">The bitmask mode.</param>
        public void SetMode(int mode)
            => _mode = mode;

        /// <summary>
        /// Disposes of managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Stop();
            _http.Dispose();
        }
    }
}
