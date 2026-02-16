using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Describes a specific size of a photo.
    /// </summary>
    public class PhotoSize
    {
        /// <summary>
        /// The proportional size type (e.g., 's', 'm', 'x').
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The URL of the image for this size.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// The width in pixels. Can be null if the size has not been processed yet.
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// The height in pixels. Can be null if the size has not been processed yet.
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("crop")]
        public bool? Crop { get; set; }

        [JsonProperty("with_padding")]
        public int? WithPadding { get; set; }
    }
}
