using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents a user who has viewed a message in a conversation.
    /// </summary>
    public class MessageViewer
    {
        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the conversation local message ID up to which the user has read.
        /// </summary>
        [JsonProperty("last_read_id")]
        public long LastReadId { get; set; }
    }
}
