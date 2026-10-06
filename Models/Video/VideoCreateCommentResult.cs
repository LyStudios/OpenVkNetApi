using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Video
{
    /// <summary>
    /// Represents the result of creating a comment on a video.
    /// </summary>
    public class VideoCreateCommentResult
    {
        /// <summary>
        /// The ID of the created comment.
        /// </summary>
        [JsonProperty("comment_id")]
        public int CommentId { get; set; }

        /// <summary>
        /// Legacy comment ID alias.
        /// </summary>
        [JsonProperty("cid")]
        public int Cid { get; set; }
    }
}
