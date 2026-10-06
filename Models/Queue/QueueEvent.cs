using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Queue
{
    /// <summary>
    /// Represents an individual event item in a real-time queue.
    /// </summary>
    public class QueueEvent
    {
        /// <summary>
        /// Queue event identifier.
        /// </summary>
        [JsonProperty("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// Event payload or raw message data.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
