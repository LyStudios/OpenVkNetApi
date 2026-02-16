using Newtonsoft.Json;

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
        [JsonProperty("message_id")]
        public int MessageId { get; set; }

        /// <summary>
        /// The new message text.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// New attachment (e.g., photo_id, video_id).
        /// </summary>
        [JsonProperty("attachment")]
        public string Attachment { get; set; } = "";

        /// <summary>
        /// ID of the peer in the conversation.
        /// </summary>
        [JsonProperty("peer_id")]
        public int PeerId { get; set; } = 0;
    }
}
