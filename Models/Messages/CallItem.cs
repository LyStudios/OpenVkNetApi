using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents an audio/video call entry in conversations.
    /// </summary>
    public class CallItem
    {
        /// <summary>
        /// Unique call identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Initiator user ID.
        /// </summary>
        [JsonProperty("initiator_id")]
        public int InitiatorId { get; set; }

        /// <summary>
        /// Receiver user or peer ID.
        /// </summary>
        [JsonProperty("receiver_id")]
        public int ReceiverId { get; set; }

        /// <summary>
        /// State of the call (e.g., "active", "completed", "canceled").
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Call start Unix timestamp.
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }

        /// <summary>
        /// Duration of the call in seconds.
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// True if video was enabled.
        /// </summary>
        [JsonProperty("is_video")]
        public bool IsVideo { get; set; }
    }
}
