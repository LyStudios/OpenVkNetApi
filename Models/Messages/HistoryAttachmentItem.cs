using Newtonsoft.Json;
using OpenVkNetApi.Models.Attachments;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents an attachment item in a conversation's media history.
    /// </summary>
    public class HistoryAttachmentItem
    {
        /// <summary>
        /// Gets or sets the message ID where the attachment was sent.
        /// </summary>
        [JsonProperty("message_id")]
        public int MessageId { get; set; }

        /// <summary>
        /// Gets or sets the attachment.
        /// </summary>
        [JsonProperty("attachment")]
        public Attachment Attachment { get; set; }
    }
}
