using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Notifications
{
    /// <summary>
    /// Represents a single notification.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// The date when the notification was generated, in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// Information about the event that triggered the notification.
        /// </summary>
        [JsonProperty("feedback")]
        public NotificationFeedback Feedback { get; set; }

        /// <summary>
        /// The notification ID.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The type of notification (e.g., "comment", "like", "friend_accepted").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Information about the parent object (e.g. post, photo, video) for the notification.
        /// </summary>
        [JsonProperty("parent")]
        public NotificationParent Parent { get; set; }
    }
}
