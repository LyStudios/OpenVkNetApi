using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Attachments;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents a comment on a photo.
    /// </summary>
    public class PhotoComment
    {
        /// <summary>
        /// The comment ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The author's ID.
        /// </summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        /// <summary>
        /// The date when the comment was created, in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// The comment text.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Information about likes on the comment.
        /// </summary>
        [JsonProperty("likes")]
        public CommentLikes? Likes { get; set; }

        /// <summary>
        /// A list of attachments in the comment.
        /// </summary>
        [JsonProperty("attachments")]
        [JsonConverter(typeof(AttachmentJsonConverter))]
        public List<Attachment>? Attachments { get; set; }
    }

    /// <summary>
    /// Represents the 'likes' object for a comment.
    /// </summary>
    public class CommentLikes
    {
        /// <summary>
        /// The total number of likes.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Whether the current user has liked this comment (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("user_likes")]
        public int UserLikes { get; set; }

        /// <summary>
        /// Whether the current user can like this comment (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("can_like")]
        public int CanLike { get; set; }
    }
}
