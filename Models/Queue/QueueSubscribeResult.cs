using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Queue
{
    /// <summary>
    /// Represents the result of queue subscription.
    /// </summary>
    public class QueueSubscribeResult
    {
        /// <summary>
        /// Queue broker base URL.
        /// </summary>
        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Subscribed queues information.
        /// </summary>
        [JsonProperty("queues")]
        public List<QueueInfo> Queues { get; set; }
    }
}
