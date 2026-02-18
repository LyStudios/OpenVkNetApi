using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Attachments;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.Comments
{
    /// <summary>
    /// Represents a base comment model.
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// The comment ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The ID of the user or community who posted the comment.
        /// </summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        /// <summary>
        /// The date when the comment was posted, in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// The text of the comment.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// A list of attachments to the comment.
        /// </summary>
        [JsonProperty("attachments")]
        [JsonConverter(typeof(AttachmentJsonConverter))]
        public List<Attachment>? Attachments { get; set; }

        /// <summary>
        /// A stack of parent comment IDs for replies.
        /// </summary>
        [JsonProperty("parents_stack")]
        public List<object>? ParentsStack { get; set; }

        /// <summary>
        /// Indicates if the current user has liked this comment (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("user_likes")]
        public int? UserLikes { get; set; }

        /// <summary>
        /// Indicates if the current user can like this comment.
        /// </summary>
        [JsonProperty("can_like")]
        public bool? CanLike { get; set; }
    }
}
