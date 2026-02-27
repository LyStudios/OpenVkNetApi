using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Wall
{
    /// <summary>
    /// Parameters for the wall.editComment method.
    /// </summary>
    public class WallEditCommentParams
    {
        /// <summary>
        /// ID of the comment to edit.
        /// </summary>
        [ApiParameter("comment_id")]
        public int CommentId { get; set; }

        /// <summary>
        /// ID of the post owner.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; } = 0;

        /// <summary>
        /// The new text of the comment.
        /// </summary>
        [ApiParameter("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// New attachments to the comment.
        /// </summary>
        [ApiParameter("attachments")]
        public string Attachments { get; set; } = "";
    }
}
