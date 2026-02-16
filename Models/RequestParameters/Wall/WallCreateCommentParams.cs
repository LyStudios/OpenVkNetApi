using Newtonsoft.Json;

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
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// ID of the post.
        /// </summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        /// <summary>
        /// The text of the comment.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// 1 to post the comment on behalf of a group.
        /// </summary>
        [JsonProperty("from_group")]
        public int FromGroup { get; set; } = 0;

        /// <summary>
        /// Attachments to the comment.
        /// </summary>
        [JsonProperty("attachments")]
        public string Attachments { get; set; } = "";
    }
}
