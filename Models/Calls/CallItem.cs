using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Calls
{
    /// <summary>
    /// Represents an individual call item in call history.
    /// </summary>
    public class CallItem
    {
        /// <summary>
        /// Call identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

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
        /// Call state.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Call start timestamp.
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }

        /// <summary>
        /// Call duration in seconds.
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }
    }
}
