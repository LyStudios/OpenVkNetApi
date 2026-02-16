using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents a private message.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// The message ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The peer ID (the user or chat the message is with).
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// The sender's ID.
        /// </summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        /// <summary>
        /// The date when the message was sent, in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// The read state of the message (1 for read, 0 for unread).
        /// </summary>
        [JsonProperty("read_state")]
        public int ReadState { get; set; }

        /// <summary>
        /// Indicates if the message is outgoing (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("out")]
        public int Out { get; set; }

        /// <summary>
        /// The message body.
        /// </summary>
        [JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// The message text.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Indicates if the message contains emoji.
        /// </summary>
        [JsonProperty("emoji")]
        public bool Emoji { get; set; }
    }
}
