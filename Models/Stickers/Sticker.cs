using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Stickers
{
    /// <summary>
    /// Represents a sticker item in the OpenVK API.
    /// </summary>
    public class Sticker
    {
        /// <summary>
        /// Gets or sets the sticker ID.
        /// </summary>
        [JsonProperty("sticker_id")]
        public int StickerId { get; set; }

        /// <summary>
        /// Gets or sets the product (pack) ID.
        /// </summary>
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the list of sticker image variants.
        /// </summary>
        [JsonProperty("images")]
        public List<StickerImage> Images { get; set; }

        /// <summary>
        /// Gets or sets the list of sticker image variants with background.
        /// </summary>
        [JsonProperty("images_with_background")]
        public List<StickerImage> ImagesWithBackground { get; set; }

        /// <summary>
        /// Gets or sets the animation URL for animated stickers.
        /// </summary>
        [JsonProperty("animation_url")]
        public string AnimationUrl { get; set; }
    }
}
