using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the legacy <c>messages.getDialogs</c> method.
    /// </summary>
    public class MessagesGetDialogsParams
    {
        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of dialogs to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 20;

        /// <summary>
        /// Number of characters after which to truncate a message.
        /// </summary>
        [ApiParameter("preview_length")]
        public int PreviewLength { get; set; } = 0;

        /// <summary>
        /// 1 to return only unread dialogs.
        /// </summary>
        [ApiParameter("unread")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Unread { get; set; } = false;

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
        /// Specific user ID.
        /// </summary>
        [ApiParameter("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Specific peer ID.
        /// </summary>
        [ApiParameter("peer_id")]
        public int? PeerId { get; set; }

        /// <summary>
        /// Specific chat ID.
        /// </summary>
        [ApiParameter("chat_id")]
        public int? ChatId { get; set; }

        /// <summary>
        /// Group ID (if called on behalf of a community).
        /// </summary>
        [ApiParameter("group_id")]
        public int? GroupId { get; set; }
    }
}
