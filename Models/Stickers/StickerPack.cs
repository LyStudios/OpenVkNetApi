using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Stickers
{
    /// <summary>
    /// Represents a sticker pack in the OpenVK API.
    /// </summary>
    public class StickerPack
    {
        /// <summary>
        /// Gets or sets the sticker pack ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the sticker pack title/name.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the sticker pack name (alias for Title).
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the author of the sticker pack.
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the description of the sticker pack.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the price of the sticker pack in votes/coins.
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sticker pack is purchased by the current user.
        /// </summary>
        [JsonProperty("purchased")]
        public bool Purchased { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sticker pack is active.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the 35px icon URL.
        /// </summary>
        [JsonProperty("photo_35")]
        public string Photo35 { get; set; }

        /// <summary>
        /// Gets or sets the 70px icon URL.
        /// </summary>
        [JsonProperty("photo_70")]
        public string Photo70 { get; set; }

        /// <summary>
        /// Gets or sets the 140px icon URL.
        /// </summary>
        [JsonProperty("photo_140")]
        public string Photo140 { get; set; }

        /// <summary>
        /// Gets or sets the 296px icon URL.
        /// </summary>
        [JsonProperty("photo_296")]
        public string Photo296 { get; set; }

        /// <summary>
        /// Gets or sets the 512px icon URL.
        /// </summary>
        [JsonProperty("photo_512")]
        public string Photo512 { get; set; }

        /// <summary>
        /// Gets or sets the list of stickers in this pack.
        /// </summary>
        [JsonProperty("stickers")]
        public List<Sticker> Stickers { get; set; }
    }
}
