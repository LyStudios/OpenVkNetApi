using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the messages.edit method.
    /// </summary>
    public class MessagesEditParams
    {
        /// <summary>
        /// The message ID to edit.
        /// </summary>
        [ApiParameter("message_id")]
        public int MessageId { get; set; }

        /// <summary>
        /// The new message text.
        /// </summary>
        [ApiParameter("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// New attachment (e.g., photo_id, video_id).
        /// </summary>
        [ApiParameter("attachment")]
        public string Attachment { get; set; } = "";

        /// <summary>
        /// ID of the peer in the conversation.
        /// </summary>
        [ApiParameter("peer_id")]
        public int PeerId { get; set; } = 0;
    }
}
