using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents a conversation (dialog, group chat or community chat)
    /// returned by the <c>messages.*</c> methods of the OpenVK API.
    /// </summary>
    public class Conversation
    {
        /// <summary>
        /// Contains information about the peer (user, group or chat)
        /// participating in the conversation.
        /// </summary>
        [JsonProperty("peer")]
        public ConversationPeer? Peer { get; set; }

        /// <summary>
        /// The ID of the last message in the conversation.
        /// </summary>
        [JsonProperty("last_message_id")]
        public int LastMessageId { get; set; }

        /// <summary>
        /// The ID of the last incoming message that has been marked as read
        /// by the current user.
        /// </summary>
        [JsonProperty("in_read")]
        public int InRead { get; set; }

        /// <summary>
        /// The ID of the last outgoing message that has been marked as read
        /// by the conversation peer.
        /// </summary>
        [JsonProperty("out_read")]
        public int OutRead { get; set; }

        /// <summary>
        /// Contains sorting information used internally by the API
        /// to order conversations.
        /// </summary>
        [JsonProperty("sort_id")]
        public SortId? SortId { get; set; }

        /// <summary>
        /// The ID of the last message within the conversation scope
        /// (conversation-specific message identifier).
        /// </summary>
        [JsonProperty("last_conversation_message_id")]
        public int? LastConversationMessageId { get; set; }

        /// <summary>
        /// The ID of the last incoming conversation message
        /// marked as read by the current user.
        /// </summary>
        [JsonProperty("in_read_cmid")]
        public int? InReadConversationMessageId { get; set; }

        /// <summary>
        /// The ID of the last outgoing conversation message
        /// marked as read by the peer.
        /// </summary>
        [JsonProperty("out_read_cmid")]
        public int? OutReadConversationMessageId { get; set; }

        /// <summary>
        /// Indicates whether the conversation is manually marked as unread
        /// by the current user.
        /// </summary>
        [JsonProperty("is_marked_unread")]
        public bool IsMarkedUnread { get; set; }

        /// <summary>
        /// Indicates whether the conversation is marked as important.
        /// </summary>
        [JsonProperty("important")]
        public bool Important { get; set; }

        /// <summary>
        /// The last message object in the conversation.
        /// </summary>
        [JsonProperty("last_message")]
        public Message? LastMessage { get; set; }

        /// <summary>
        /// Contains information about whether the current user
        /// is allowed to send messages to this conversation.
        /// </summary>
        [JsonProperty("can_write")]
        public ConversationCanWrite? CanWrite { get; set; }
    }
}
