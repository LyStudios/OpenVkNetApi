using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Groups
{
    /// <summary>
    /// Represents the settings of a group.
    /// </summary>
    public class GroupSettings
    {
        /// <summary>
        /// The group title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The group description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The group's address or short name.
        /// </summary>
        [JsonProperty("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Wall settings (0 - off, 1 - open, 2 - limited, 3 - closed).
        /// </summary>
        [JsonProperty("wall")]
        public int Wall { get; set; }

        /// <summary>
        /// Photos settings.
        /// </summary>
        [JsonProperty("photos")]
        public int Photos { get; set; }

        /// <summary>
        /// Video settings.
        /// </summary>
        [JsonProperty("video")]
        public int Video { get; set; }

        /// <summary>
        /// Audio settings.
        /// </summary>
        [JsonProperty("audio")]
        public int Audio { get; set; }

        /// <summary>
        /// Docs settings.
        /// </summary>
        [JsonProperty("docs")]
        public int Docs { get; set; }

        /// <summary>
        /// Topics (board) settings.
        /// </summary>
        [JsonProperty("topics")]
        public int Topics { get; set; }

        /// <summary>
        /// The group's website.
        /// </summary>
        [JsonProperty("website")]
        public string? Website { get; set; }
    }
}
