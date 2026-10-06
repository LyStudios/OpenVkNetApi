using System.Collections.Generic;
using Newtonsoft.Json;
using OpenVkNetApi.Models.Stickers;

namespace OpenVkNetApi.Models.Store
{
    /// <summary>
    /// Represents stickers keyword mapping for instant sticker suggestions.
    /// </summary>
    public class StickersKeywords
    {
        /// <summary>
        /// Total number of keyword entries.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Mapping from keywords/emoji to sticker IDs.
        /// </summary>
        [JsonProperty("dictionary")]
        public Dictionary<string, List<int>> Dictionary { get; set; } = new Dictionary<string, List<int>>();

        /// <summary>
        /// Stickers metadata if requested.
        /// </summary>
        [JsonProperty("stickers")]
        public List<Sticker> Stickers { get; set; } = new List<Sticker>();
    }
}
