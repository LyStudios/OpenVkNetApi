using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents the result of updating or deleting a chat photo.
    /// </summary>
    public class ChatPhotoResult
    {
        /// <summary>
        /// Gets or sets the service message ID generated for the photo change.
        /// </summary>
        [JsonProperty("message_id")]
        public int MessageId { get; set; }

        /// <summary>
        /// Gets or sets the updated chat object.
        /// </summary>
        [JsonProperty("chat")]
        public Chat Chat { get; set; }
    }
}
