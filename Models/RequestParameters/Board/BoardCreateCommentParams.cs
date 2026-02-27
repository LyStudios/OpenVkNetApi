using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Board
{
    /// <summary>
    /// Parameters for the board.createComment method.
    /// </summary>
    public class BoardCreateCommentParams
    {
        /// <summary>
        /// ID of the community.
        /// </summary>
        [ApiParameter("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// ID of the topic.
        /// </summary>
        [ApiParameter("topic_id")]
        public int TopicId { get; set; }

        /// <summary>
        /// The text of the comment.
        /// </summary>
        [ApiParameter("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// True if the comment is published on behalf of the group.
        /// </summary>
        [ApiParameter("from_group")]
        public bool FromGroup { get; set; } = true;
    }
}
