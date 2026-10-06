using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Notifications
{
    /// <summary>
    /// Represents feedback information (e.g. comment or like info) attached to a notification.
    /// </summary>
    public class NotificationFeedback
    {
        /// <summary>
        /// Feedback target ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// ID of the user who performed the action.
        /// </summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        /// <summary>
        /// Text associated with the feedback (e.g. comment text).
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Date of the feedback event in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }
    }
}
