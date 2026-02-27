using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Wall
{
    /// <summary>
    /// Parameters for the wall.getComment method.
    /// </summary>
    public class WallGetCommentParams
    {
        /// <summary>
        /// ID of the post owner.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// ID of the comment.
        /// </summary>
        [ApiParameter("comment_id")]
        public int CommentId { get; set; }

        /// <summary>
        /// 1 to return extended information about users.
        /// </summary>
        [ApiParameter("extended")]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;
    }
}
