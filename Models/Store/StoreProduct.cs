using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Store
{
    /// <summary>
    /// Represents a product (such as a sticker pack) in the OpenVK store catalog.
    /// </summary>
    public class StoreProduct
    {
        /// <summary>
        /// Product ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Type of the product (e.g. "stickers").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Product title / name.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Product name (alias for title).
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the product.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Author / creator of the product.
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// 1 if the current user purchased this product, 0 otherwise.
        /// </summary>
        [JsonProperty("purchased")]
        public int Purchased { get; set; }

        /// <summary>
        /// 1 if active, 0 otherwise.
        /// </summary>
        [JsonProperty("active")]
        public int Active { get; set; }

        /// <summary>
        /// Price in coins/votes.
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Formatted price string (e.g. "Бесплатно" or "10 монет").
        /// </summary>
        [JsonProperty("price_str")]
        public string PriceStr { get; set; }

        /// <summary>
        /// URL to 128px preview.
        /// </summary>
        [JsonProperty("photo_128")]
        public string Photo128 { get; set; }

        /// <summary>
        /// URL to 256px preview.
        /// </summary>
        [JsonProperty("photo_256")]
        public string Photo256 { get; set; }

        /// <summary>
        /// URL to 512px preview.
        /// </summary>
        [JsonProperty("photo_512")]
        public string Photo512 { get; set; }

        /// <summary>
        /// True if the sticker pack contains animated stickers.
        /// </summary>
        [JsonProperty("is_animated")]
        public bool IsAnimated { get; set; }

        /// <summary>
        /// Number of stickers in the pack.
        /// </summary>
        [JsonProperty("stickers_count")]
        public int StickersCount { get; set; }

        /// <summary>
        /// List of sticker IDs in the pack.
        /// </summary>
        [JsonProperty("sticker_ids")]
        public List<int> StickerIds { get; set; } = new List<int>();
    }
}
