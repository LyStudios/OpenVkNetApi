using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the legacy <c>messages.get</c> method.
    /// </summary>
    public class MessagesGetParams
    {
        /// <summary>
        /// 1 for outgoing messages, 0 for incoming.
        /// </summary>
        [ApiParameter("out")]
        public int Out { get; set; } = 0;

        /// <summary>
        /// Offset needed to return a specific subset of messages.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of messages to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 20;

        /// <summary>
        /// Maximum time since a message was sent, in seconds.
        /// </summary>
        [ApiParameter("time_offset")]
        public int TimeOffset { get; set; } = 0;

        /// <summary>
        /// Filter flags (1: unread, 2: not from chat, 4: from friends, 8: important).
        /// </summary>
        [ApiParameter("filters")]
        public int Filters { get; set; } = 0;

        /// <summary>
        /// Number of characters after which to truncate a message.
        /// </summary>
        [ApiParameter("preview_length")]
        public int PreviewLength { get; set; } = 0;

        /// <summary>
        /// ID of the message received before the current request.
        /// </summary>
        [ApiParameter("last_message_id")]
        public long LastMessageId { get; set; } = 0;

        /// <summary>
        /// 1 to return extended user and group profiles.
        /// </summary>
        [ApiParameter("extended")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// Additional profile fields to return.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// Group ID (if called on behalf of a community).
        /// </summary>
        [ApiParameter("group_id")]
        public long? GroupId { get; set; }
    }
}
