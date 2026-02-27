using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the messages.getConversations method.
    /// </summary>
    public class MessagesGetConversationsParams
    {
        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of conversations to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 20;

        /// <summary>
        /// Filter for conversations (e.g., "all", "unread", "important").
        /// </summary>
        [ApiParameter("filter")]
        public string Filter { get; set; } = "all";

        /// <summary>
        /// 1 to return extended information about users and groups.
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
