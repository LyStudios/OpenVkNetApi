using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Gifts
{
    /// <summary>
    /// Represents the localized name and description for a gift category.
    /// </summary>
    public class GiftCategoryLocalization
    {
        /// <summary>
        /// The localized name.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The localized description.
        /// </summary>
        [JsonProperty("desc")]
        public string? Description { get; set; }
    }
}
