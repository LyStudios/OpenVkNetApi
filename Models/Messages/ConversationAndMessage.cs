using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents an item in the result of the messages.getConversations method.
    /// Wraps both the conversation metadata and the last message.
    /// </summary>
    public class ConversationAndMessage
    {
        /// <summary>
        /// Information about the conversation.
        /// </summary>
        [JsonProperty("conversation")]
        public Conversation Conversation { get; set; }

        /// <summary>
        /// The last message in the conversation.
        /// </summary>
        [JsonProperty("last_message")]
        public Message LastMessage { get; set; }
    }
}