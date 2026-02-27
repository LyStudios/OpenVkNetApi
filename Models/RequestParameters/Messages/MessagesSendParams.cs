using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the messages.send method.
    /// </summary>
    public class MessagesSendParams
    {
        /// <summary>
        /// User ID.
        /// </summary>
        [ApiParameter("user_id")]
        public int UserId { get; set; } = -1;

        /// <summary>
        /// Peer ID.
        /// </summary>
        [ApiParameter("peer_id")]
        public int PeerId { get; set; } = -1;

        /// <summary>
        /// User's domain name.
        /// </summary>
        [ApiParameter("domain")]
        public string Domain { get; set; } = "";

        /// <summary>
        /// Chat ID.
        /// </summary>
        [ApiParameter("chat_id")]
        public int ChatId { get; set; } = -1;

        /// <summary>
        /// Comma-separated list of user IDs to send a message to.
        /// </summary>
        [ApiParameter("user_ids")]
        public string UserIds { get; set; } = "";

        /// <summary>
        /// Message text.
        /// </summary>
        [ApiParameter("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// Sticker ID.
        /// </summary>
        [ApiParameter("sticker_id")]
        public int StickerId { get; set; } = -1;

        /// <summary>
        /// A special flag to prevent reporting about online activity.
        /// </summary>
        [ApiParameter("forGodSakePleaseDoNotReportAboutMyOnlineActivity")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool ForGodSakePleaseDoNotReportAboutMyOnlineActivity { get; set; } = false;

        /// <summary>
        /// Attachment (e.g., photo_id, video_id).
        /// </summary>
        [ApiParameter("attachment")]
        public string Attachment { get; set; } = "";
    }
}
