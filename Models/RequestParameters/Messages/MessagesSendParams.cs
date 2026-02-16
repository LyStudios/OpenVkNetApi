using Newtonsoft.Json;

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
        [JsonProperty("user_id")]
        public int UserId { get; set; } = -1;

        /// <summary>
        /// Peer ID.
        /// </summary>
        [JsonProperty("peer_id")]
        public int PeerId { get; set; } = -1;

        /// <summary>
        /// User's domain name.
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; } = "";

        /// <summary>
        /// Chat ID.
        /// </summary>
        [JsonProperty("chat_id")]
        public int ChatId { get; set; } = -1;

        /// <summary>
        /// Comma-separated list of user IDs to send a message to.
        /// </summary>
        [JsonProperty("user_ids")]
        public string UserIds { get; set; } = "";

        /// <summary>
        /// Message text.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// Sticker ID.
        /// </summary>
        [JsonProperty("sticker_id")]
        public int StickerId { get; set; } = -1;

        /// <summary>
        /// A special flag to prevent reporting about online activity.
        /// </summary>
        [JsonProperty("forGodSakePleaseDoNotReportAboutMyOnlineActivity")]
        public int ForGodSakePleaseDoNotReportAboutMyOnlineActivity { get; set; } = 0;

        /// <summary>
        /// Attachment (e.g., photo_id, video_id).
        /// </summary>
        [JsonProperty("attachment")]
        public string Attachment { get; set; } = "";
    }
}
