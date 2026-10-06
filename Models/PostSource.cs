using Newtonsoft.Json;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Information about how and where the post was created.
    /// </summary>
    public class PostSource
    {
        /// <summary>
        /// Source type (e.g., "vk", "widget", "api", "rss", "sms").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Platform from which the post was sent (e.g., "android", "iphone", "wphone").
        /// </summary>
        [JsonProperty("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// Additional action or context data (e.g., "profile_photo", "profile_activity").
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// URL associated with the source.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
