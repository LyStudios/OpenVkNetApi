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

        private readonly HashSet<int> _recentIds = new HashSet<int>();
        private const int MAX_CACHE = 1000;

        private bool _running;

        private int _wait = 25;
        private readonly int _version = 3;

        /// <summary>
        /// Occurs when a new message is received via Long Poll.
        /// </summary>
        public event EventHandler<NewMessageEventArgs> OnMessageNew;
        /// <summary>
        /// Occurs when a user starts typing a message in a conversation.
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

                    string url =
                        $"{_lp.Server}" +
                        $"?act=a_check" +
                        $"&key={_lp.Key}" +
                        $"&ts={_lp.Ts}" +
                        $"&wait={_wait}" +
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

                if (type == 61)
                {
                    int userId = SafeInt(u, 1);
                    if (userId > 0)
                    {
                        OnUserTyping?.Invoke(this, new UserTypingEventArgs(userId, userId));
                    }
                    continue;
                }

                if (type == 62)
                {
                    int userId = SafeInt(u, 1);
                    int chatId = SafeInt(u, 2);
                    if (userId > 0 && chatId > 0)
                    {
                        int peerId = 2000000000 + chatId;
                        OnUserTyping?.Invoke(this, new UserTypingEventArgs(userId, peerId, chatId));
                    }
                    continue;
                }

                if (type != 4) continue; // only new messages

                int msgId = SafeInt(u, 1);
                if (msgId == 0) continue;

                if (!_recentIds.Add(msgId))
                    continue;

                TrimCache();

                var msg = new Message
                {
                    Id = msgId,
                    Date = SafeLong(u, 4),
                    Text = u.Count > 5 ? u[5]?.ToString() : null,
                    FromId = u.Count > 9 ? SafeInt(u, 9) : SafeInt(u, 3)
                };

                OnMessageNew?.Invoke(this, new NewMessageEventArgs(msg));
            }
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
        /// Sets the Long Poll wait time for server responses.
        /// </summary>
        /// <param name="seconds">The number of seconds to wait. Clamped between 0 and 60 seconds.</param>
        public void SetWait(int seconds)
            => _wait = Math.Max(0, Math.Min(60, seconds));

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
