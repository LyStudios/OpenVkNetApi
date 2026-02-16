using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Gifts
{
    /// <summary>
    /// Represents a gift received by a user.
    /// </summary>
    public class UserGift
    {
        /// <summary>
        /// The ID of the user who sent the gift.
        /// </summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        /// <summary>
        /// A message included with the gift.
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The date when the gift was sent, in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// The gift object.
        /// </summary>
        [JsonProperty("gift")]
        public Gift? Gift { get; set; }
    }
}
