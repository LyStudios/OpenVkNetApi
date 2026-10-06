using Newtonsoft.Json;
using OpenVkNetApi.Models.Photos;

namespace OpenVkNetApi.Models.Comments
{
    /// <summary>
    /// Represents a comment on a video.
    /// </summary>
    public class VideoComment : Comment
    {
        /// <summary>
        /// Legacy comment ID alias.
        /// </summary>
        [JsonProperty("cid")]
        public int Cid { get; set; }

        /// <summary>
        /// Legacy author user ID alias.
        /// </summary>
        [JsonProperty("uid")]
        public int Uid { get; set; }

        /// <summary>
        /// Comment text alias.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Target comment ID for reply.
        /// </summary>
        [JsonProperty("reply_to_cid")]
        public int ReplyToCid { get; set; }

        /// <summary>
        /// Author ID of the replied-to comment.
        /// </summary>
        [JsonProperty("reply_to_uid")]
        public int ReplyToUid { get; set; }

        /// <summary>
        /// Likes information for the comment.
        /// </summary>
        [JsonProperty("likes")]
        public PhotoLikes Likes { get; set; }
    }
}
