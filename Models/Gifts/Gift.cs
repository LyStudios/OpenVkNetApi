using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Gifts
{
    /// <summary>
    /// Represents a gift object with different thumbnail sizes.
    /// </summary>
    public class Gift
    {
        /// <summary>
        /// The gift ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The URL of the 256x256px thumbnail.
        /// </summary>
        [JsonProperty("thumb_256")]
        public string? Thumb256 { get; set; }

        /// <summary>
        /// The URL of the 96x96px thumbnail.
        /// </summary>
        [JsonProperty("thumb_96")]
        public string? Thumb96 { get; set; }

        /// <summary>
        /// The URL of the 48x48px thumbnail.
        /// </summary>
        [JsonProperty("thumb_48")]
        public string? Thumb48 { get; set; }
    }
}
