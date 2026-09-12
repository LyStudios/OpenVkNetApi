using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Stickers
{
    /// <summary>
    /// Represents an image size variant of a sticker.
    /// </summary>
    public class StickerImage
    {
        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the image width.
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the image height.
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}
