using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents the metadata and URL of the original photo.
    /// </summary>
    public class OriginalPhoto
    {
        /// <summary>
        /// Gets or sets the height of the original photo in pixels.
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the width of the original photo in pixels.
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the size/type designation of the photo (e.g., "s", "m", "x", "y").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the absolute URL of the photo file.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
