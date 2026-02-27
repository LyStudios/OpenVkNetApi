using Newtonsoft.Json.Linq;
using OpenVkNetApi.Builders;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Models.Messages;
using OpenVkNetApi.Models.RequestParameters.Messages;
using OpenVkNetApi.Utils;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with private messages.
    /// Encapsulates the <c>messages.*</c> methods of the OpenVK API.
    /// </summary>
    public class Messages : MethodBase
    {
        private readonly Photos _photosApi;
        /// <summary>
        /// Initializes a new instance of the <see cref="Messages"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Messages(OpenVkApi api) : base(api, "messages")
        {
            _photosApi = api.Photos;
        }

        /// <summary>
        /// Creates a new <see cref="MessageBuilder"/> instance for fluent message construction.
        /// </summary>
        /// <returns>A new <see cref="MessageBuilder"/>.</returns>
        public MessageBuilder CreateBuilder()
        {
            return new MessageBuilder(this, _photosApi);
        }

        /// <summary>
        /// Returns a list of messages by their IDs.
        /// </summary>
        /// <param name="messageIds">A comma-separated list of message IDs.</param>
        /// <param name="previewLength">The number of characters to return from the message text.</param>
        /// <param name="extended">True to return extended information.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Message}"/> of message objects.</returns>
        public async Task<Collection<Message>> GetByIdAsync(string messageIds, int previewLength = 0, bool extended = false, CancellationToken ct = default)
        { 
            var parameters = new RequestParams()
                .Add("message_ids", messageIds)
                .Add("preview_length", previewLength)
                .Add("extended", extended ? 1 : 0)
                .ToDictionary();

            return await GetAsync<Collection<Message>>("getById", parameters, ct);
        }

        /// <summary>
        /// Sends a message.
        /// </summary>
        /// <param name="params">Parameters for the message.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The ID of the sent message, or an array of IDs if multiple recipients were specified.</returns>
        public async Task<List<int>> SendAsync(MessagesSendParams @params, CancellationToken ct = default)
        {
            var result = await PostAsync<JToken>("send", @params, ct);

            if (result.Type == JTokenType.Array)
                return result.ToObject<List<int>>()!;

            return new List<int> { result.ToObject<int>() };
        }

        /// <summary>
        /// Deletes one or more messages.
        /// </summary>
        /// <param name="messageIds">A comma-separated list of message IDs to delete.</param>
        /// <param name="spam">True to mark the messages as spam.</param>
        /// <param name="deleteForAll">True to delete the messages for all recipients.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Dictionary<string, int>"/> object with the results of the deletion.</returns>
        public async Task<Dictionary<string, int>> DeleteAsync(string messageIds, bool spam = false, bool deleteForAll = false, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("message_ids", messageIds)
                .Add("spam", spam ? 1 : 0)
                .Add("delete_for_all", deleteForAll ? 1 : 0)
                .ToDictionary();
            return await PostAsync<Dictionary<string, int>>("delete", parameters, ct);
        }

        /// <summary>
        /// Restores a deleted message.
        /// </summary>
        /// <param name="messageId">The ID of the message to restore.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> RestoreAsync(int messageId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("message_id", messageId)
                .ToDictionary();

            return await PostAsync<int>("restore", parameters, ct);
        }

        /// <summary>
        /// Returns a list of the current user's conversations.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="MessagesGetConversationsResponse"/> object containing conversations.</returns>
        public async Task<ExtendedCollection<Conversation>> GetConversationsAsync(MessagesGetConversationsParams @params, CancellationToken ct = default)
        {
            return await GetAsync<ExtendedCollection<Conversation>>("getConversations", @params, ct);
        }

        /// <summary>
        /// Returns information about conversations by their IDs.
        /// </summary>
        /// <param name="peerIds">A comma-separated list of peer IDs.</param>
        /// <param name="extended">True to return extended information.</param>
        /// <param name="fields">A list of additional profile fields to return.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="MessagesGetConversationsResponse"/> object containing conversations.</returns>
        public async Task<ExtendedCollection<Conversation>> GetConversationsByIdAsync(string peerIds, bool extended = false, UserFields fields = UserFields.None, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_ids", peerIds)
                .Add("extended", extended ? 1 : 0)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .ToDictionary();

            return await GetAsync<ExtendedCollection<Conversation>>("getConversationsById", parameters, ct);
        }

        /// <summary>
        /// Returns a list of messages from a conversation's history.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="ExtendedCollection<Message>"/> object containing messages.</returns>
        public async Task<ExtendedCollection<Message>> GetHistoryAsync(MessagesGetHistoryParams @params, CancellationToken ct = default)
        {
            return await GetAsync<ExtendedCollection<Message>>("getHistory", @params, ct);
        }

        /// <summary>
        /// Returns updates to a user's conversations using the long polling mechanism.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="LongPollHistory"/> object with updates.</returns>
        public async Task<LongPollHistory> GetLongPollHistoryAsync(MessagesGetLongPollHistoryParams @params, CancellationToken ct = default)
        {
            return await GetAsync<LongPollHistory>("getLongPollHistory", @params, ct);
        }

        /// <summary>
        /// Returns the server and credentials for the long poll connection.
        /// </summary>
        /// <param name="needPts">True to return the 'pts' field.</param>
        /// <param name="lpVersion">The long poll version.</param>
        /// <param name="groupId">The group ID (if for a community).</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="LongPollServerInfo"/> object with connection data.</returns>
        public async Task<LongPollServerInfo> GetLongPollServerAsync(int needPts = 1, int lpVersion = 3, int? groupId = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("need_pts", needPts)
                .Add("lp_version", lpVersion)
                .Add("group_id", groupId)
                .ToDictionary();

            return await GetAsync<LongPollServerInfo>("getLongPollServer", parameters, ct);
        }

        /// <summary>
        /// Edits a message.
        /// </summary>
        /// <param name="params">Parameters for the edit operation.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> EditAsync(MessagesEditParams @params, CancellationToken ct = default)
        {
            return await PostAsync<int>("edit", @params, ct);
        }
    }
}
