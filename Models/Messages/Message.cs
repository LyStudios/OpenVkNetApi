using Newtonsoft.Json;
using OpenVkNetApi.Models.Attachments;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents a private message returned by the <c>messages.*</c> methods
    /// of the OpenVK API.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// The unique identifier of the message.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The peer identifier (user ID, chat ID, or community ID)
        /// associated with the message.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// The identifier of the user or community that sent the message.
        /// </summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        /// <summary>
        /// The date and time when the message was sent,
        /// represented as a Unix timestamp (seconds since 01.01.1970 UTC).
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// The read state of the message.
        /// A value of <c>1</c> indicates that the message has been read,
        /// and <c>0</c> indicates that it is unread.
        /// </summary>
        [JsonProperty("read_state")]
        public int ReadState { get; set; }

        /// <summary>
        /// Indicates whether the message is outgoing.
        /// A value of <c>1</c> means the message was sent by the current user,
        /// and <c>0</c> means it is incoming.
        /// </summary>
        [JsonProperty("out")]
        public int Out { get; set; }

        /// <summary>
        /// The title of the message (used primarily in chat conversations).
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The message body (legacy field, may duplicate <see cref="Text"/>).
        /// </summary>
        [JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// The text content of the message.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// A collection of attachments associated with the message
        /// (photos, videos, documents, audio, etc.).
        /// </summary>
        [JsonProperty("attachments")]
        public List<Attachment>? Attachments { get; set; }

        /// <summary>
        /// A collection of forwarded messages attached to this message.
        /// </summary>
        [JsonProperty("fwd_messages")]
        public List<Message>? ForwardedMessages { get; set; }

        /// <summary>
        /// Indicates whether the message contains emoji.
        /// </summary>
        [JsonProperty("emoji")]
        public bool Emoji { get; set; }

        /// <summary>
        /// Indicates whether the message is marked as important.
        /// </summary>
        [JsonProperty("important")]
        public bool Important { get; set; }

        /// <summary>
        /// Indicates whether the message has been deleted.
        /// A value of <c>1</c> means deleted, and <c>0</c> means active.
        /// </summary>
        [JsonProperty("deleted")]
        public int Deleted { get; set; }

        /// <summary>
        /// A unique identifier used to prevent duplicate message sending.
        /// </summary>
        [JsonProperty("random_id")]
        public int RandomId { get; set; }
    }
}
