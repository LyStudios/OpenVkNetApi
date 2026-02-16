using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents a conversation or dialog.
    /// </summary>
    public class Conversation
    {
        /// <summary>
        /// The last message in the conversation.
        /// </summary>
        [JsonProperty("last_message")]
        public Message? LastMessage { get; set; }

        /// <summary>
        /// Information about the peer in the conversation.
        /// </summary>
        [JsonProperty("peer")]
        public ConversationPeer? Peer { get; set; }

        /// <summary>
        /// Information about whether the current user can write to this conversation.
        /// </summary>
        [JsonProperty("can_write")]
        public ConversationCanWrite? CanWrite { get; set; }
    }
}
