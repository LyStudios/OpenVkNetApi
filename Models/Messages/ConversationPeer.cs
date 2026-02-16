using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents the peer (the other participant) in a conversation.
    /// </summary>
    public class ConversationPeer
    {
        /// <summary>
        /// The peer's ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The peer's type (e.g., "user", "group", "chat").
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The local ID within a chat.
        /// </summary>
        [JsonProperty("local_id")]
        public int LocalId { get; set; }
    }
}
