using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Queue
{
    /// <summary>
    /// Represents an individual queue subscription state.
    /// </summary>
    public class QueueInfo
    {
        /// <summary>
        /// Queue identifier string.
        /// </summary>
        [JsonProperty("queue_id")]
        public string QueueId { get; set; }

        /// <summary>
        /// Alternative queue identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Queue broker base URL.
        /// </summary>
        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Queue name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Security access key for the queue.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Timestamp string for the queue polling.
        /// </summary>
        [JsonProperty("ts")]
        public string Ts { get; set; }

        /// <summary>
        /// Numeric timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        /// <summary>
        /// Wait timeout in seconds.
        /// </summary>
        [JsonProperty("wait")]
        public int Wait { get; set; }

        /// <summary>
        /// Initial pending events array.
        /// </summary>
        [JsonProperty("events")]
        public List<QueueEvent> Events { get; set; }
    }
}
