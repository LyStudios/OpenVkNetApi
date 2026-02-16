using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Ovk
{
    /// <summary>
    /// Represents an external link associated with the OpenVK instance.
    /// </summary>
    public class OvkAboutInstanceLink
    {
        /// <summary>
        /// The URL of the link.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The title or description of the link.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }
    }
}
