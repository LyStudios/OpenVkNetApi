using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Gifts
{
    /// <summary>
    /// Represents a gift item from the catalog.
    /// </summary>
    public class CatalogGift
    {
        /// <summary>
        /// The name of the gift.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The URL of the gift's image.
        /// </summary>
        [JsonProperty("image")]
        public string? Image { get; set; }

        /// <summary>
        /// The number of times the gift can still be used.
        /// </summary>
        [JsonProperty("usages_left")]
        public int UsagesLeft { get; set; }

        /// <summary>
        /// The price of the gift in votes.
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Indicates if the gift is free.
        /// </summary>
        [JsonProperty("is_free")]
        public bool IsFree { get; set; }
    }
}
