using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Notifications
{
    /// <summary>
    /// Represents the parent object (post, photo, video, comment) for a notification.
    /// </summary>
    public class NotificationParent
    {
        /// <summary>
        /// Object ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Object owner ID.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Text or description of the object.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Date of object creation in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// Related post ID if the object is on a wall.
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }
    }
}
