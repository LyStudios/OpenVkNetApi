using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the messages.getHistory method.
    /// </summary>
    public class MessagesGetHistoryParams
    {
        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of messages to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 20;

        /// <summary>
        /// User ID. Use 'peer_id' instead if possible.
        /// </summary>
        [ApiParameter("user_id")]
        public int UserId { get; set; } = -1;

        /// <summary>
        /// Peer ID.
        /// </summary>
        [ApiParameter("peer_id")]
        public int PeerId { get; set; } = -1;

        /// <summary>
        /// Start message ID. Messages will be returned starting from this ID.
        /// </summary>
        [ApiParameter("start_message_id")]
        public int StartMessageId { get; set; } = 0;

        /// <summary>
        /// True to return messages in reverse chronological order.
        /// </summary>
        [ApiParameter("rev")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Rev { get; set; } = false;

        /// <summary>
        /// True to return extended information about users and groups.
        /// </summary>
        [ApiParameter("extended")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;
    }
}