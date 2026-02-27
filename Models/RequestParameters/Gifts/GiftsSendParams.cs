using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Gifts
{
    /// <summary>
    /// Parameters for the gifts.send method.
    /// </summary>
    public class GiftsSendParams
    {
        /// <summary>
        /// ID of the user to whom the gift will be sent.
        /// </summary>
        [ApiParameter("user_ids")]
        public int UserIds { get; set; }

        /// <summary>
        /// ID of the gift to send.
        /// </summary>
        [ApiParameter("gift_id")]
        public int GiftId { get; set; }

        /// <summary>
        /// A message to include with the gift.
        /// </summary>
        [ApiParameter("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// Privacy settings for the gift (0 - public, 1 - private).
        /// </summary>
        [ApiParameter("privacy")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Privacy { get; set; } = false;
    }
}
