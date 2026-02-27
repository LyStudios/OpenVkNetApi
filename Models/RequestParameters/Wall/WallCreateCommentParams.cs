using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Wall
{
    /// <summary>
    /// Parameters for the wall.createComment method.
    /// </summary>
    public class WallCreateCommentParams
    {
        /// <summary>
        /// ID of the post owner.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// ID of the post.
        /// </summary>
        [ApiParameter("post_id")]
        public int PostId { get; set; }

        /// <summary>
        /// The text of the comment.
        /// </summary>
        [ApiParameter("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// 1 to post the comment on behalf of a group.
        /// </summary>
        [ApiParameter("from_group")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool FromGroup { get; set; } = false;

        /// <summary>
        /// Attachments to the comment.
        /// </summary>
        [ApiParameter("attachments")]
        public string Attachments { get; set; } = "";
    }
}
