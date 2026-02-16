using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Gifts
{
    /// <summary>
    /// Represents a category of gifts.
    /// </summary>
    public class GiftCategory
    {
        /// <summary>
        /// The category name.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The category description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The category ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The URL of the category's thumbnail.
        /// </summary>
        [JsonProperty("thumbnail")]
        public string? Thumbnail { get; set; }

        /// <summary>
        /// A dictionary of localizations for the category.
        /// </summary>
        [JsonProperty("localizations")]
        public Dictionary<string, GiftCategoryLocalization>? Localizations { get; set; }
    }
}
