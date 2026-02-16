using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Messages;
using OpenVkNetApi.Models.RequestParameters.Messages;
using OpenVkNetApi.Utils;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with private messages.
    /// Encapsulates the <c>messages.*</c> methods of the OpenVK API.
    /// </summary>
    public class Messages : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Messages"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Messages(OpenVkApi api) : base(api, "messages") { }

        /// <summary>
        /// Returns a list of messages by their IDs.
        /// </summary>
        /// <param name="messageIds">A comma-separated list of message IDs.</param>
        /// <param name="previewLength">The number of characters to return from the message text.</param>
        /// <param name="extended">True to return extended information.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Message}"/> of message objects.</returns>
        public async Task<Collection<Message>> GetByIdAsync(string messageIds, int previewLength = 0, int extended = 0, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["message_ids"] = messageIds,
                ["preview_length"] = previewLength.ToString(),
                ["extended"] = extended.ToString()
            };
            return await GetAsync<Collection<Message>>("getById", parameters, ct);
        }

        /// <summary>
        /// Sends a message.
        /// </summary>
        /// <param name="params">Parameters for the message.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The ID of the sent message, or an array of IDs if multiple recipients were specified.</returns>
        public async Task<object> SendAsync(MessagesSendParams @params, CancellationToken ct = default)
        {
            return await PostAsync<object>("send", @params, ct);
        }

        /// <summary>
        /// Deletes one or more messages.
        /// </summary>
        /// <param name="messageIds">A comma-separated list of message IDs to delete.</param>
        /// <param name="spam">True to mark the messages as spam.</param>
        /// <param name="deleteForAll">True to delete the messages for all recipients.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="MessagesDelete"/> object with the results of the deletion.</returns>
        public async Task<MessagesDelete> DeleteAsync(string messageIds, int spam = 0, int deleteForAll = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("message_ids", messageIds)
                .Add("spam", spam)
                .Add("delete_for_all", deleteForAll)
                .ToDictionary();
            return await PostAsync<MessagesDelete>("delete", parameters, ct);
        }

        /// <summary>
        /// Restores a deleted message.
        /// </summary>
        /// <param name="messageId">The ID of the message to restore.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> RestoreAsync(int messageId, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["message_id"] = messageId.ToString()
            };
            return await PostAsync<int>("restore", parameters, ct);
        }

        /// <summary>
        /// Returns a list of the current user's conversations.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="MessagesGetConversationsResponse"/> object containing conversations.</returns>
        public async Task<MessagesGetConversationsResponse> GetConversationsAsync(MessagesGetConversationsParams @params, CancellationToken ct = default)
        {
            return await GetAsync<MessagesGetConversationsResponse>("getConversations", @params, ct);
        }

        /// <summary>
        /// Returns information about conversations by their IDs.
        /// </summary>
        /// <param name="peerIds">A comma-separated list of peer IDs.</param>
        /// <param name="extended">True to return extended information.</param>
        /// <param name="fields">A list of additional profile fields to return.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="MessagesGetConversationsResponse"/> object containing conversations.</returns>
        public async Task<MessagesGetConversationsResponse> GetConversationsByIdAsync(string peerIds, int extended = 0, UserFields fields = UserFields.None, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["peer_ids"] = peerIds,
                ["extended"] = extended.ToString(),
                ["fields"] = EnumHelper.GetEnumFlagsDescription(fields)
            };
            return await GetAsync<MessagesGetConversationsResponse>("getConversationsById", parameters, ct);
        }

        /// <summary>
        /// Returns a list of messages from a conversation's history.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="MessagesGetHistoryResponse"/> object containing messages.</returns>
        public async Task<MessagesGetHistoryResponse> GetHistoryAsync(MessagesGetHistoryParams @params, CancellationToken ct = default)
        {
            return await GetAsync<MessagesGetHistoryResponse>("getHistory", @params, ct);
        }

        /// <summary>
        /// Returns updates to a user's conversations using the long polling mechanism.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="MessagesGetLongPollHistoryResponse"/> object with updates.</returns>
        public async Task<MessagesGetLongPollHistoryResponse> GetLongPollHistoryAsync(MessagesGetLongPollHistoryParams @params, CancellationToken ct = default)
        {
            return await GetAsync<MessagesGetLongPollHistoryResponse>("getLongPollHistory", @params, ct);
        }

        /// <summary>
        /// Returns the server and credentials for the long poll connection.
        /// </summary>
        /// <param name="needPts">True to return the 'pts' field.</param>
        /// <param name="lpVersion">The long poll version.</param>
        /// <param name="groupId">The group ID (if for a community).</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="MessagesGetLongPollServer"/> object with connection data.</returns>
        public async Task<MessagesGetLongPollServer> GetLongPollServerAsync(int needPts = 1, int lpVersion = 3, int? groupId = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["need_pts"] = needPts.ToString(),
                ["lp_version"] = lpVersion.ToString()
            };
            if (groupId.HasValue)
            {
                parameters["group_id"] = groupId.Value.ToString();
            }
            return await GetAsync<MessagesGetLongPollServer>("getLongPollServer", parameters, ct);
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
