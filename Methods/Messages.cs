using Newtonsoft.Json.Linq;
using OpenVkNetApi.Builders;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Models.Groups;
using OpenVkNetApi.Models.Messages;
using OpenVkNetApi.Models.Photos;
using OpenVkNetApi.Models.RequestParameters.Messages;
using OpenVkNetApi.Models.Users;
using OpenVkNetApi.Utils;
using System.Collections.Generic;
using System.Linq;
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
                return result.ToObject<List<int>>();

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
        /// <returns>A <see cref="ExtendedCollection<ConversationAndMessage>"/> object containing conversations.</returns>
        public async Task<ExtendedCollection<ConversationAndMessage>> GetConversationsAsync(MessagesGetConversationsParams @params, CancellationToken ct = default)
        {
            return await GetAsync<ExtendedCollection<ConversationAndMessage>>("getConversations", @params, ct);
        }

        /// <summary>
        /// Returns information about conversations by their IDs.
        /// </summary>
        /// <param name="peerIds">A comma-separated list of peer IDs.</param>
        /// <param name="extended">True to return extended information.</param>
        /// <param name="fields">A list of additional profile fields to return.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="ExtendedCollection{Conversation}"/> containing conversations.</returns>
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

            return await PostAsync<LongPollServerInfo>("getLongPollServer", parameters, ct);
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

        /// <summary>
        /// Sends activity status (e.g., typing) to a conversation peer.
        /// </summary>
        /// <param name="userId">The ID of the user (deprecated/alias for peerId).</param>
        /// <param name="type">The type of activity (currently only "typing" is supported).</param>
        /// <param name="peerId">The ID of the peer conversation.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> SetActivityAsync(int userId = 0, string type = "typing", int peerId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("user_id", userId)
                .Add("type", type)
                .Add("peer_id", peerId)
                .ToDictionary();

            return await PostAsync<int>("setActivity", parameters, ct);
        }

        /// <summary>
        /// Creates a new group chat.
        /// </summary>
        /// <param name="title">The title of the chat.</param>
        /// <param name="userIds">A list of user IDs to include in the chat.</param>
        /// <param name="groupId">The group ID (if called on behalf of a community).</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The ID of the created chat.</returns>
        public async Task<int> CreateChatAsync(string title, IEnumerable<int> userIds = null, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("title", title)
                .Add("user_ids", userIds != null ? string.Join(",", userIds) : null)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await PostAsync<int>("createChat", parameters, ct);
        }

        /// <summary>
        /// Returns information about a group chat by its ID.
        /// </summary>
        /// <param name="chatId">The chat ID.</param>
        /// <param name="extended">True to return extended information.</param>
        /// <param name="fields">A list of additional profile fields to return.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Chat"/> object.</returns>
        public async Task<Chat> GetChatAsync(int chatId, bool extended = false, UserFields fields = UserFields.None, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("chat_id", chatId)
                .Add("extended", extended ? 1 : 0)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<Chat>("getChat", parameters, ct);
        }

        /// <summary>
        /// Returns information about multiple group chats by their IDs.
        /// </summary>
        /// <param name="chatIds">A collection of chat IDs.</param>
        /// <param name="extended">True to return extended information.</param>
        /// <param name="fields">A list of additional profile fields to return.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="Chat"/> objects.</returns>
        public async Task<List<Chat>> GetChatAsync(IEnumerable<int> chatIds, bool extended = false, UserFields fields = UserFields.None, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("chat_ids", chatIds != null ? string.Join(",", chatIds) : "")
                .Add("extended", extended ? 1 : 0)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<List<Chat>>("getChat", parameters, ct);
        }

        /// <summary>
        /// Returns a list of users participating in a chat.
        /// </summary>
        /// <param name="chatId">The chat ID.</param>
        /// <param name="fields">Profile fields to return.</param>
        /// <param name="nameCase">Grammatical case for user names.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="User"/> objects.</returns>
        public async Task<List<User>> GetChatUsersAsync(int chatId, UserFields fields = UserFields.None, string nameCase = "nom", int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("chat_id", chatId)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .Add("name_case", nameCase)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<List<User>>("getChatUsers", parameters, ct);
        }

        /// <summary>
        /// Adds a new user to a chat.
        /// </summary>
        /// <param name="chatId">The chat ID.</param>
        /// <param name="userId">The ID of the user to add.</param>
        /// <param name="peerId">The peer ID (optional alternative).</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> AddChatUserAsync(int chatId, int userId, int peerId = 0, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("chat_id", chatId)
                .Add("user_id", userId)
                .Add("peer_id", peerId > 0 ? peerId : (int?)null)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await PostAsync<int>("addChatUser", parameters, ct);
        }

        /// <summary>
        /// Removes a user from a chat.
        /// </summary>
        /// <param name="chatId">The chat ID.</param>
        /// <param name="userId">The ID of the user to remove.</param>
        /// <param name="peerId">The peer ID (optional alternative).</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> RemoveChatUserAsync(int chatId, int userId, int peerId = 0, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("chat_id", chatId)
                .Add("user_id", userId)
                .Add("peer_id", peerId > 0 ? peerId : (int?)null)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await PostAsync<int>("removeChatUser", parameters, ct);
        }

        /// <summary>
        /// Edits the title of a group chat.
        /// </summary>
        /// <param name="chatId">The chat ID.</param>
        /// <param name="title">The new title of the chat.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> EditChatAsync(int chatId, string title, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("chat_id", chatId)
                .Add("title", title)
                .ToDictionary();

            return await PostAsync<int>("editChat", parameters, ct);
        }

        /// <summary>
        /// Sets a new photo for a chat.
        /// </summary>
        /// <param name="chatId">The chat ID.</param>
        /// <param name="file">The uploaded file parameter returned by the upload server.</param>
        /// <param name="hash">The upload hash parameter.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="ChatPhotoResult"/> with updated chat data.</returns>
        public async Task<ChatPhotoResult> SetChatPhotoAsync(int chatId, string file, string hash, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("chat_id", chatId)
                .Add("file", file)
                .Add("hash", hash)
                .ToDictionary();

            return await PostAsync<ChatPhotoResult>("setChatPhoto", parameters, ct);
        }

        /// <summary>
        /// Deletes the photo of a chat.
        /// </summary>
        /// <param name="chatId">The chat ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="ChatPhotoResult"/> with updated chat data.</returns>
        public async Task<ChatPhotoResult> DeleteChatPhotoAsync(int chatId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("chat_id", chatId)
                .ToDictionary();

            return await PostAsync<ChatPhotoResult>("deleteChatPhoto", parameters, ct);
        }

        /// <summary>
        /// Generates or returns an invite link to join a group chat.
        /// </summary>
        /// <param name="peerId">The peer ID of the chat (> 2000000000).</param>
        /// <param name="chatId">The chat ID (if peerId not provided).</param>
        /// <param name="reset">True to generate a new invite link and invalidate the previous one.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The invite link URL string.</returns>
        public async Task<string> GetInviteLinkAsync(int peerId = 0, int chatId = 0, bool reset = false, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId > 0 ? peerId : (int?)null)
                .Add("chat_id", chatId > 0 ? chatId : (int?)null)
                .Add("reset", reset ? 1 : 0)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            var res = await GetAsync<JObject>("getInviteLink", parameters, ct);
            return res?["link"]?.ToString();
        }

        /// <summary>
        /// Returns preview information for a chat using an invite link.
        /// </summary>
        /// <param name="link">The invite link URL or code.</param>
        /// <param name="fields">Profile fields to return for chat members.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="ChatPreviewDetails"/> containing chat preview data.</returns>
        [AllowAnonymous]
        public async Task<ChatPreviewDetails> GetChatPreviewAsync(string link, UserFields fields = UserFields.None, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("link", link)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<ChatPreviewDetails>("getChatPreview", parameters, ct);
        }

        /// <summary>
        /// Joins a chat using an invite link.
        /// </summary>
        /// <param name="link">The invite link URL or code.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The ID of the joined chat.</returns>
        public async Task<int> JoinChatByInviteLinkAsync(string link, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("link", link)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            var res = await PostAsync<JObject>("joinChatByInviteLink", parameters, ct);
            return res?["chat_id"]?.Value<int>() ?? 0;
        }

        /// <summary>
        /// Joins a chat linked to a board topic.
        /// </summary>
        /// <param name="groupId">The community ID.</param>
        /// <param name="topicId">The discussion topic ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The ID of the joined chat.</returns>
        public async Task<int> JoinChatByTopicAsync(int groupId, int topicId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .Add("topic_id", topicId)
                .ToDictionary();

            var res = await PostAsync<JToken>("joinChatByTopic", parameters, ct);
            if (res is JObject obj && obj["chat_id"] != null)
                return obj["chat_id"].Value<int>();

            return res?.Value<int>() ?? 1;
        }

        /// <summary>
        /// Appoints a chat member as a moderator (admin).
        /// </summary>
        /// <param name="userId">The ID of the user to appoint.</param>
        /// <param name="peerId">The peer ID of the chat.</param>
        /// <param name="chatId">The chat ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> SetChatModeratorAsync(int userId, int peerId = 0, int chatId = 0, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("user_id", userId)
                .Add("peer_id", peerId > 0 ? peerId : (int?)null)
                .Add("chat_id", chatId > 0 ? chatId : (int?)null)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await PostAsync<int>("setChatModerator", parameters, ct);
        }

        /// <summary>
        /// Dismisses a moderator back to a regular chat member.
        /// </summary>
        /// <param name="userId">The ID of the user to dismiss.</param>
        /// <param name="peerId">The peer ID of the chat.</param>
        /// <param name="chatId">The chat ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> RemoveChatModeratorAsync(int userId, int peerId = 0, int chatId = 0, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("user_id", userId)
                .Add("peer_id", peerId > 0 ? peerId : (int?)null)
                .Add("chat_id", chatId > 0 ? chatId : (int?)null)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await PostAsync<int>("removeChatModerator", parameters, ct);
        }

        /// <summary>
        /// Returns the list of moderators and the owner of a group chat.
        /// </summary>
        /// <param name="peerId">The peer ID of the chat.</param>
        /// <param name="chatId">The chat ID.</param>
        /// <param name="extended">True to return extended profile information.</param>
        /// <param name="fields">Profile fields to return for moderators.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="ChatModerators"/> object.</returns>
        public async Task<ChatModerators> GetChatModeratorsAsync(int peerId = 0, int chatId = 0, bool extended = false, UserFields fields = UserFields.None, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId > 0 ? peerId : (int?)null)
                .Add("chat_id", chatId > 0 ? chatId : (int?)null)
                .Add("extended", extended ? 1 : 0)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<ChatModerators>("getChatModerators", parameters, ct);
        }

        /// <summary>
        /// Pins a message in a conversation.
        /// </summary>
        /// <param name="peerId">The peer ID of the conversation.</param>
        /// <param name="messageId">The message ID.</param>
        /// <param name="conversationMessageId">The conversation-specific message ID (cmid).</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The pinned <see cref="Message"/> object.</returns>
        public async Task<Message> PinAsync(int peerId, int messageId, int conversationMessageId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId)
                .Add("message_id", messageId)
                .Add("conversation_message_id", conversationMessageId > 0 ? conversationMessageId : (int?)null)
                .ToDictionary();

            return await PostAsync<Message>("pin", parameters, ct);
        }

        /// <summary>
        /// Unpins the currently pinned message in a conversation.
        /// </summary>
        /// <param name="peerId">The peer ID of the conversation.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> UnpinAsync(int peerId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId)
                .ToDictionary();

            return await PostAsync<int>("unpin", parameters, ct);
        }

        /// <summary>
        /// Marks messages as read.
        /// </summary>
        /// <param name="messageIds">A list of message IDs to mark as read.</param>
        /// <param name="peerId">The conversation peer ID.</param>
        /// <param name="startMessageId">The message ID from which to mark read.</param>
        /// <param name="markConversationAsRead">True to mark the entire conversation as read.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> MarkAsReadAsync(IEnumerable<int> messageIds = null, int peerId = 0, int startMessageId = 0, bool markConversationAsRead = false, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("message_ids", messageIds != null ? string.Join(",", messageIds) : null)
                .Add("peer_id", peerId > 0 ? peerId : (int?)null)
                .Add("start_message_id", startMessageId > 0 ? startMessageId : (int?)null)
                .Add("mark_conversation_as_read", markConversationAsRead ? 1 : 0)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await PostAsync<int>("markAsRead", parameters, ct);
        }

        /// <summary>
        /// Marks or unmarks messages as important (starred).
        /// </summary>
        /// <param name="messageIds">A list of message IDs.</param>
        /// <param name="important">True to mark as important, false to unmark.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A list of message IDs that were marked.</returns>
        public async Task<List<int>> MarkAsImportantAsync(IEnumerable<int> messageIds, bool important = true, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("message_ids", messageIds != null ? string.Join(",", messageIds) : "")
                .Add("important", important ? 1 : 0)
                .ToDictionary();

            return await PostAsync<List<int>>("markAsImportant", parameters, ct);
        }

        /// <summary>
        /// Returns a list of the current user's important messages.
        /// </summary>
        /// <param name="count">The number of messages to return.</param>
        /// <param name="offset">Offset for pagination.</param>
        /// <param name="startMessageId">Start message ID.</param>
        /// <param name="previewLength">Preview length for message text.</param>
        /// <param name="extended">True to return extended profile information.</param>
        /// <param name="fields">Profile fields to return.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="ExtendedCollection{Message}"/> containing important messages.</returns>
        public async Task<ExtendedCollection<Message>> GetImportantMessagesAsync(int count = 20, int offset = 0, int startMessageId = 0, int previewLength = 0, bool extended = false, UserFields fields = UserFields.None, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("count", count)
                .Add("offset", offset)
                .Add("start_message_id", startMessageId > 0 ? startMessageId : (int?)null)
                .Add("preview_length", previewLength)
                .Add("extended", extended ? 1 : 0)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .ToDictionary();

            return await GetAsync<ExtendedCollection<Message>>("getImportantMessages", parameters, ct);
        }

        /// <summary>
        /// Returns messages by their conversation-specific message IDs (cmid).
        /// </summary>
        /// <param name="peerId">The conversation peer ID.</param>
        /// <param name="conversationMessageIds">List of conversation-specific message IDs.</param>
        /// <param name="extended">True to return extended profile information.</param>
        /// <param name="fields">Profile fields to return.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="ExtendedCollection{Message}"/> containing messages.</returns>
        public async Task<ExtendedCollection<Message>> GetByConversationMessageIdAsync(int peerId, IEnumerable<int> conversationMessageIds, bool extended = false, UserFields fields = UserFields.None, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId)
                .Add("conversation_message_ids", conversationMessageIds != null ? string.Join(",", conversationMessageIds) : "")
                .Add("extended", extended ? 1 : 0)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<ExtendedCollection<Message>>("getByConversationMessageId", parameters, ct);
        }

        /// <summary>
        /// Returns the message nearest to the specified Unix timestamp date.
        /// </summary>
        /// <param name="peerId">The conversation peer ID.</param>
        /// <param name="date">The target Unix timestamp date.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The nearest <see cref="Message"/> object.</returns>
        public async Task<Message> GetNearestMessageForDateAsync(int peerId, long date, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId)
                .Add("date", date)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<Message>("getNearestMessageForDate", parameters, ct);
        }

        /// <summary>
        /// Returns media attachments (photos, audio, videos, documents) from a conversation's history.
        /// </summary>
        /// <param name="peerId">The conversation peer ID.</param>
        /// <param name="mediaType">The media type (photo, video, audio, doc, link, market, wall, share).</param>
        /// <param name="startFrom">Starting point string for pagination.</param>
        /// <param name="count">Number of attachments to return.</param>
        /// <param name="photoSizes">True to return multiple photo sizes.</param>
        /// <param name="fields">Profile fields to return.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="ExtendedCollection{HistoryAttachmentItem}"/> containing attachment items and pagination cursor.</returns>
        public async Task<ExtendedCollection<HistoryAttachmentItem>> GetHistoryAttachmentsAsync(int peerId, string mediaType = "photo", string startFrom = "", int count = 30, bool photoSizes = false, UserFields fields = UserFields.None, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId)
                .Add("media_type", mediaType)
                .Add("start_from", startFrom)
                .Add("count", count)
                .Add("photo_sizes", photoSizes ? 1 : 0)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<ExtendedCollection<HistoryAttachmentItem>>("getHistoryAttachments", parameters, ct);
        }

        /// <summary>
        /// Searches for messages matching a search query.
        /// </summary>
        /// <param name="query">Search query string.</param>
        /// <param name="peerId">Filter by conversation peer ID.</param>
        /// <param name="date">Filter by date timestamp.</param>
        /// <param name="previewLength">Preview length for message text.</param>
        /// <param name="offset">Offset for pagination.</param>
        /// <param name="count">Number of messages to return.</param>
        /// <param name="extended">True to return extended profile information.</param>
        /// <param name="fields">Profile fields to return.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="ExtendedCollection{Message}"/> of found messages.</returns>
        public async Task<ExtendedCollection<Message>> SearchAsync(string query, int peerId = 0, long? date = null, int previewLength = 0, int offset = 0, int count = 20, bool extended = false, UserFields fields = UserFields.None, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("q", query)
                .Add("peer_id", peerId > 0 ? peerId : (int?)null)
                .Add("date", date)
                .Add("preview_length", previewLength)
                .Add("offset", offset)
                .Add("count", count)
                .Add("extended", extended ? 1 : 0)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<ExtendedCollection<Message>>("search", parameters, ct);
        }

        /// <summary>
        /// Searches for conversations matching a query string.
        /// </summary>
        /// <param name="query">Search query string.</param>
        /// <param name="count">Number of conversations to return.</param>
        /// <param name="extended">True to return extended profile information.</param>
        /// <param name="fields">Profile fields to return.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="ExtendedCollection{Conversation}"/> of found conversations.</returns>
        public async Task<ExtendedCollection<Conversation>> SearchConversationsAsync(string query, int count = 20, bool extended = false, UserFields fields = UserFields.None, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("q", query)
                .Add("count", count)
                .Add("extended", extended ? 1 : 0)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<ExtendedCollection<Conversation>>("searchConversations", parameters, ct);
        }

        /// <summary>
        /// Returns the full list of members in a conversation.
        /// </summary>
        /// <param name="peerId">The conversation peer ID.</param>
        /// <param name="extended">True to return extended profile information.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="ExtendedCollection{ConversationMember}"/> of conversation members.</returns>
        public async Task<ExtendedCollection<ConversationMember>> GetConversationMembersAsync(int peerId, bool extended = false, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId)
                .Add("extended", extended ? 1 : 0)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<ExtendedCollection<ConversationMember>>("getConversationMembers", parameters, ct);
        }

        /// <summary>
        /// Marks or unmarks a conversation as important.
        /// </summary>
        /// <param name="peerId">The conversation peer ID.</param>
        /// <param name="important">True to mark as important, false to unmark.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> MarkAsImportantConversationAsync(int peerId, bool important = true, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId)
                .Add("important", important ? 1 : 0)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await PostAsync<int>("markAsImportantConversation", parameters, ct);
        }

        /// <summary>
        /// Marks or unmarks a conversation as answered.
        /// </summary>
        /// <param name="peerId">The conversation peer ID.</param>
        /// <param name="answered">True to mark as answered, false to unmark.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> MarkAsAnsweredConversationAsync(int peerId, bool answered = true, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId)
                .Add("answered", answered ? 1 : 0)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await PostAsync<int>("markAsAnsweredConversation", parameters, ct);
        }

        /// <summary>
        /// Deletes all messages in a conversation for the current user.
        /// </summary>
        /// <param name="peerId">The conversation peer ID.</param>
        /// <param name="userId">The user ID (optional alternative).</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> DeleteConversationAsync(int peerId, int userId = 0, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId)
                .Add("user_id", userId > 0 ? userId : (int?)null)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await PostAsync<int>("deleteConversation", parameters, ct);
        }

        /// <summary>
        /// Returns the last activity timestamp and online status for a user.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="UserLastActivity"/> object.</returns>
        [AllowAnonymous]
        public async Task<UserLastActivity> GetLastActivityAsync(int userId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("user_id", userId)
                .ToDictionary();

            return await GetAsync<UserLastActivity>("getLastActivity", parameters, ct);
        }

        /// <summary>
        /// Returns a list of members who have viewed a specific message in a conversation.
        /// </summary>
        /// <param name="peerId">The conversation peer ID.</param>
        /// <param name="conversationMessageId">The conversation message ID (cmid).</param>
        /// <param name="messageId">The global message ID.</param>
        /// <param name="extended">True to return extended profile information.</param>
        /// <param name="fields">Profile fields to return for viewers.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="ExtendedCollection{MessageViewer}"/> of message viewers.</returns>
        public async Task<ExtendedCollection<MessageViewer>> GetMessageViewersAsync(int peerId, int conversationMessageId = 0, int messageId = 0, bool extended = false, UserFields fields = UserFields.None, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId)
                .Add("conversation_message_id", conversationMessageId > 0 ? conversationMessageId : (int?)null)
                .Add("message_id", messageId > 0 ? messageId : (int?)null)
                .Add("extended", extended ? 1 : 0)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<ExtendedCollection<MessageViewer>>("getMessageViewers", parameters, ct);
        }

        /// <summary>
        /// Submits a complaint/report about a message.
        /// </summary>
        /// <param name="peerId">The conversation peer ID.</param>
        /// <param name="messageId">The conversation message ID (cmid) to report.</param>
        /// <param name="type">The reason type (e.g., "spam", "insult", "porn", "advertisement").</param>
        /// <param name="comment">Additional comment describing the violation.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> ReportAsync(int peerId, int messageId, string type = "spam", string comment = "", int? groupId = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId)
                .Add("message_id", messageId)
                .Add("type", type)
                .Add("comment", comment)
                .Add("group_id", groupId)
                .ToDictionary();

            return await PostAsync<int>("report", parameters, ct);
        }

        /// <summary>
        /// Returns the count of unread messages for the current user.
        /// </summary>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The number of unread messages.</returns>
        public async Task<int> GetUnreadMessagesCountAsync(int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            var res = await GetAsync<JObject>("getUnreadMessages", parameters, ct);
            return res?["count"]?.Value<int>() ?? res?["messages"]?.Value<int>() ?? 0;
        }

        /// <summary>
        /// Returns the count of unread conversations for the current user.
        /// </summary>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The number of unread conversations.</returns>
        public async Task<int> GetUnreadConversationsCountAsync(int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            var res = await GetAsync<JObject>("getUnreadConversations", parameters, ct);
            return res?["count"]?.Value<int>() ?? 0;
        }

        /// <summary>
        /// Returns current user information in the IM service.
        /// </summary>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="JObject"/> containing user data.</returns>
        public async Task<JObject> GetMeAsync(int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<JObject>("getMe", parameters, ct);
        }

        /// <summary>
        /// Allows a community to send messages to the current user.
        /// </summary>
        /// <param name="groupId">The group ID.</param>
        /// <param name="key">Optional verification key.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> AllowMessagesFromGroupAsync(int groupId, string key = "", CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .Add("key", key)
                .ToDictionary();

            return await PostAsync<int>("allowMessagesFromGroup", parameters, ct);
        }

        /// <summary>
        /// Denies a community from sending messages to the current user.
        /// </summary>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> DenyMessagesFromGroupAsync(int groupId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .ToDictionary();

            return await PostAsync<int>("denyMessagesFromGroup", parameters, ct);
        }

        /// <summary>
        /// Checks whether a community is allowed to send messages to the specified user.
        /// </summary>
        /// <param name="groupId">The group ID.</param>
        /// <param name="userId">The user ID to check.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns><c>true</c> if messages from the group are allowed; otherwise, <c>false</c>.</returns>
        public async Task<bool> IsMessagesFromGroupAllowedAsync(int groupId, int userId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .Add("user_id", userId > 0 ? userId : (int?)null)
                .ToDictionary();

            var res = await GetAsync<JObject>("isMessagesFromGroupAllowed", parameters, ct);
            return res?["is_allowed"]?.Value<int>() == 1;
        }

        #region Folders

        /// <summary>
        /// Creates a new dialog folder.
        /// </summary>
        /// <param name="name">Name of the folder.</param>
        /// <param name="includedPeerIds">Peer IDs to include in the folder.</param>
        /// <param name="type">Type of the folder ("custom").</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The ID of the created folder.</returns>
        public async Task<int> CreateFolderAsync(string name, IEnumerable<int> includedPeerIds = null, string type = "custom", CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("name", name)
                .Add("type", type)
                .Add("included_peer_ids", includedPeerIds)
                .ToDictionary();

            var res = await PostAsync<JObject>("createFolder", parameters, ct);
            return res?["folder_id"]?.Value<int>() ?? 0;
        }

        /// <summary>
        /// Creates a new dialog folder using parameter object.
        /// </summary>
        public async Task<int> CreateFolderAsync(MessagesCreateFolderParams @params, CancellationToken ct = default)
        {
            var res = await PostAsync<JObject>("createFolder", @params, ct);
            return res?["folder_id"]?.Value<int>() ?? 0;
        }

        /// <summary>
        /// Returns a list of dialog folders.
        /// </summary>
        public async Task<Collection<MessageFolder>> GetFoldersAsync(bool withPeers = false, UserFields fields = UserFields.None, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("with_peers", withPeers ? 1 : 0)
                .Add("fields", fields)
                .ToDictionary();

            return await GetAsync<Collection<MessageFolder>>("getFolders", parameters, ct);
        }

        /// <summary>
        /// Returns a list of dialog folders using parameter object.
        /// </summary>
        public async Task<Collection<MessageFolder>> GetFoldersAsync(MessagesGetFoldersParams @params, CancellationToken ct = default)
        {
            return await GetAsync<Collection<MessageFolder>>("getFolders", @params, ct);
        }

        /// <summary>
        /// Updates a dialog folder.
        /// </summary>
        public async Task<bool> UpdateFolderAsync(int folderId, string name = null, IEnumerable<int> addPeerIds = null, IEnumerable<int> removePeerIds = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("folder_id", folderId)
                .Add("name", name)
                .Add("add_included_peer_ids", addPeerIds)
                .Add("remove_included_peer_ids", removePeerIds)
                .ToDictionary();

            var res = await PostAsync<int>("updateFolder", parameters, ct);
            return res == 1;
        }

        /// <summary>
        /// Updates a dialog folder using parameter object.
        /// </summary>
        public async Task<bool> UpdateFolderAsync(MessagesUpdateFolderParams @params, CancellationToken ct = default)
        {
            var res = await PostAsync<int>("updateFolder", @params, ct);
            return res == 1;
        }

        /// <summary>
        /// Deletes a dialog folder.
        /// </summary>
        public async Task<bool> DeleteFolderAsync(int folderId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("folder_id", folderId)
                .ToDictionary();

            var res = await PostAsync<int>("deleteFolder", parameters, ct);
            return res == 1;
        }

        /// <summary>
        /// Reorders dialog folders.
        /// </summary>
        public async Task<bool> ReorderFoldersAsync(IEnumerable<int> folderIds, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("folder_ids", folderIds)
                .ToDictionary();

            var res = await PostAsync<int>("reorderFolders", parameters, ct);
            return res == 1;
        }

        /// <summary>
        /// Reorders dialog folders using parameter object.
        /// </summary>
        public async Task<bool> ReorderFoldersAsync(MessagesReorderFoldersParams @params, CancellationToken ct = default)
        {
            var res = await PostAsync<int>("reorderFolders", @params, ct);
            return res == 1;
        }

        /// <summary>
        /// Returns recommended dialog folders.
        /// </summary>
        public async Task<List<MessageFolder>> GetRecommendedFoldersAsync(UserFields fields = UserFields.None, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("fields", fields)
                .ToDictionary();

            var res = await GetAsync<JObject>("getRecommendedFolders", parameters, ct);
            return res?["items"]?.ToObject<List<MessageFolder>>() ?? new List<MessageFolder>();
        }

        #endregion

        #region Roles and Permissions

        /// <summary>
        /// Changes a participant's role in a group chat (e.g., "admin" or "member").
        /// </summary>
        public async Task<bool> SetMemberRoleAsync(int peerId, int memberId, string role, int chatId = 0, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId)
                .Add("member_id", memberId)
                .Add("user_id", memberId)
                .Add("role", role)
                .Add("chat_id", chatId > 0 ? chatId : (int?)null)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            var res = await PostAsync<int>("setMemberRole", parameters, ct);
            return res == 1;
        }

        /// <summary>
        /// Changes a participant's role using parameter object.
        /// </summary>
        public async Task<bool> SetMemberRoleAsync(MessagesSetMemberRoleParams @params, CancellationToken ct = default)
        {
            var res = await PostAsync<int>("setMemberRole", @params, ct);
            return res == 1;
        }

        /// <summary>
        /// Sets granular permissions in a chat.
        /// </summary>
        public async Task<bool> SetChatPermissionsAsync(MessagesSetChatPermissionsParams @params, CancellationToken ct = default)
        {
            var res = await PostAsync<int>("setChatPermissions", @params, ct);
            return res == 1;
        }

        /// <summary>
        /// Returns chat avatar photo history.
        /// </summary>
        public async Task<Collection<Photo>> GetChatAvatarHistoryAsync(int chatId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("chat_id", chatId)
                .ToDictionary();

            return await GetAsync<Collection<Photo>>("getChatAvatarHistory", parameters, ct);
        }

        #endregion

        #region Counters and Sync

        /// <summary>
        /// Returns overall messaging counters (unread messages, requests, folders, calls, etc.).
        /// </summary>
        public async Task<MessagesCounters> GetCountersAsync(int filter = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("filter", filter)
                .ToDictionary();

            return await GetAsync<MessagesCounters>("getCounters", parameters, ct);
        }

        /// <summary>
        /// Returns reactions assets metadata.
        /// </summary>
        public async Task<ReactionsAssets> GetReactionsAssetsAsync(int reactionsHash = 0, int assetsHash = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("reactions_hash", reactionsHash)
                .Add("assets_hash", assetsHash)
                .ToDictionary();

            return await GetAsync<ReactionsAssets>("getReactionsAssets", parameters, ct);
        }

        /// <summary>
        /// Returns feature onboarding status.
        /// </summary>
        public async Task<FeatureOnboarding> GetFeatureOnboardingAsync(string type = "", string key = "", CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("type", type)
                .Add("key", key)
                .ToDictionary();

            return await GetAsync<FeatureOnboarding>("getFeatureOnboarding", parameters, ct);
        }

        /// <summary>
        /// Performs incremental sync of messages, conversations, and state.
        /// </summary>
        public async Task<MessagesDiff> GetDiffAsync(MessagesGetDiffParams @params, CancellationToken ct = default)
        {
            return await GetAsync<MessagesDiff>("getDiff", @params, ct);
        }

        /// <summary>
        /// Returns diff content payload.
        /// </summary>
        public async Task<List<ConversationDiffInfo>> GetDiffContentAsync(int nestedLimit = 0, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("nested_limit", nestedLimit)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            var res = await GetAsync<JObject>("getDiffContent", parameters, ct);
            return res?["items"]?.ToObject<List<ConversationDiffInfo>>() ?? new List<ConversationDiffInfo>();
        }

        #endregion

        #region Calls

        /// <summary>
        /// Returns groups available for making a call.
        /// </summary>
        public async Task<Collection<Group>> GetGroupsForCallAsync(UserFields fields = UserFields.None, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("fields", fields)
                .ToDictionary();

            return await GetAsync<Collection<Group>>("getGroupsForCall", parameters, ct);
        }

        /// <summary>
        /// Returns list of recent calls.
        /// </summary>
        public async Task<ExtendedCollection<CallItem>> GetRecentCallsAsync(int count = 20, int startMessageId = 0, UserFields fields = UserFields.None, bool extended = false, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("count", count)
                .Add("start_message_id", startMessageId > 0 ? startMessageId : (int?)null)
                .Add("fields", fields)
                .Add("extended", extended ? 1 : 0)
                .ToDictionary();

            return await GetAsync<ExtendedCollection<CallItem>>("getRecentCalls", parameters, ct);
        }

        /// <summary>
        /// Returns list of scheduled calls.
        /// </summary>
        public async Task<ExtendedCollection<CallItem>> GetScheduledCallsAsync(int count = 20, string startFrom = "", UserFields fields = UserFields.None, bool extended = false, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("count", count)
                .Add("start_from", startFrom)
                .Add("fields", fields)
                .Add("extended", extended ? 1 : 0)
                .ToDictionary();

            return await GetAsync<ExtendedCollection<CallItem>>("getScheduledCalls", parameters, ct);
        }

        /// <summary>
        /// Returns list of current active calls.
        /// </summary>
        public async Task<ExtendedCollection<CallItem>> GetCurrentCallsAsync(UserFields fields = UserFields.None, bool extended = false, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("fields", fields)
                .Add("extended", extended ? 1 : 0)
                .ToDictionary();

            return await GetAsync<ExtendedCollection<CallItem>>("getCurrentCalls", parameters, ct);
        }

        #endregion

        #region Legacy Aliases

        /// <summary>
        /// Legacy method to retrieve messages list.
        /// </summary>
        public async Task<ExtendedCollection<Message>> GetAsync(MessagesGetParams @params, CancellationToken ct = default)
        {
            return await GetAsync<ExtendedCollection<Message>>("get", @params, ct);
        }

        /// <summary>
        /// Legacy method to retrieve list of dialogs.
        /// </summary>
        public async Task<ExtendedCollection<ConversationAndMessage>> GetDialogsAsync(MessagesGetDialogsParams @params, CancellationToken ct = default)
        {
            return await GetAsync<ExtendedCollection<ConversationAndMessage>>("getDialogs", @params, ct);
        }

        /// <summary>
        /// Searches dialogs matching the specified query.
        /// </summary>
        public async Task<List<ConversationAndMessage>> SearchDialogsAsync(string query, int limit = 20, UserFields fields = UserFields.None, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("q", query)
                .Add("limit", limit)
                .Add("fields", fields)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .ToDictionary();

            return await GetAsync<List<ConversationAndMessage>>("searchDialogs", parameters, ct);
        }

        /// <summary>
        /// Deletes all messages in a dialog (legacy alias for deleteConversation).
        /// </summary>
        public async Task<bool> DeleteDialogAsync(int peerId = 0, int userId = 0, int offset = 0, int count = 0, int groupId = 0, int chatId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("peer_id", peerId > 0 ? peerId : (int?)null)
                .Add("user_id", userId > 0 ? userId : (int?)null)
                .Add("offset", offset > 0 ? offset : (int?)null)
                .Add("count", count > 0 ? count : (int?)null)
                .Add("group_id", groupId > 0 ? groupId : (int?)null)
                .Add("chat_id", chatId > 0 ? chatId : (int?)null)
                .ToDictionary();

            var res = await PostAsync<int>("deleteDialog", parameters, ct);
            return res == 1;
        }

        #endregion
    }
}
