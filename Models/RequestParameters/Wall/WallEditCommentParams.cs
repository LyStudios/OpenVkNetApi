using Newtonsoft.Json;

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
        [JsonProperty("comment_id")]
        public int CommentId { get; set; }

        /// <summary>
        /// ID of the post owner.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; } = 0;

        /// <summary>
        /// The new text of the comment.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// New attachments to the comment.
        /// </summary>
        [JsonProperty("attachments")]
        public string Attachments { get; set; } = "";
    }
}
