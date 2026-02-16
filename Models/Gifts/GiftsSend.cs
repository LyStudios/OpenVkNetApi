using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Gifts
{
    /// <summary>
    /// Represents the result of a gifts.send API call.
    /// </summary>
    public class GiftsSend
    {
        /// <summary>
        /// Indicates if the operation was successful (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("success")]
        public int Success { get; set; }

        /// <summary>
        /// The ID of the recipient user.
        /// </summary>
        [JsonProperty("user_ids")]
        public int UserIds { get; set; }

        /// <summary>
        /// The number of votes withdrawn for the gift.
        /// </summary>
        [JsonProperty("withdraw_votes")]
        public int? WithdrawVotes { get; set; }

        /// <summary>
        /// An error message, if the operation failed.
        /// </summary>
        [JsonProperty("error")]
        public string? Error { get; set; }
    }
}
