using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Represents the queue subscription.
    /// </summary>
    public class AudioQueueSubscription
    {
        /// <summary>
        /// The queue URL.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
