using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Search
{
    /// <summary>
    /// Represents a search hint or suggestion item.
    /// </summary>
    public class SearchHint
    {
        /// <summary>
        /// Hint type (e.g., "profile", "group").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Hint description or title.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
