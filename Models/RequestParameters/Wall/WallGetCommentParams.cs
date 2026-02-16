using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

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
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// ID of the comment.
        /// </summary>
        [JsonProperty("comment_id")]
        public int CommentId { get; set; }

        /// <summary>
        /// 1 to return extended information about users.
        /// </summary>
        [JsonProperty("extended")]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [JsonProperty("fields")]
        public UserFields Fields { get; set; } = UserFields.None;
    }
}
