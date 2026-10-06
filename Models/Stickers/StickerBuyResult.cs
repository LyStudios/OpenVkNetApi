using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Stickers
{
    /// <summary>
    /// Represents the result of buying a sticker pack.
    /// </summary>
    public class StickerBuyResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether the purchase was successful (usually 1).
        /// </summary>
        [JsonProperty("success")]
        public int Success { get; set; }

        /// <summary>
        /// Gets or sets the ID of the purchased sticker pack.
        /// </summary>
        [JsonProperty("pack_id")]
        public int PackId { get; set; }
    }
}
