using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Apps
{
    /// <summary>
    /// Represents a mini app catalog item.
    /// </summary>
    public class MiniAppItem
    {
        /// <summary>
        /// App identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// App title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// App description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// App icon URL.
        /// </summary>
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }
    }
}
