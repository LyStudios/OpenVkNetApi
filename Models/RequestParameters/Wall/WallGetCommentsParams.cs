using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Wall
{
    /// <summary>
    /// Parameters for the wall.getComments method.
    /// </summary>
    public class WallGetCommentsParams
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
        /// True to return the 'likes' object.
        /// </summary>
        [ApiParameter("need_likes")]
        public bool NeedLikes { get; set; } = true;

        /// <summary>
        /// Offset needed to return a specific subset of comments.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of comments to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// Sort order of comments ("asc" or "desc").
        /// </summary>
        [ApiParameter("sort")]
        public string Sort { get; set; } = "asc";

        /// <summary>
        /// True to return extended information about users who posted comments.
        /// </summary>
        [ApiParameter("extended")]
        public bool Extended { get; set; } = false;
    }
}
