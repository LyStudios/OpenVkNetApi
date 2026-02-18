using Newtonsoft.Json;
using OpenVkNetApi.Models.Wall;

namespace OpenVkNetApi.Models.Comments
{
    /// <summary>
    /// Represents a comment on a wall post.
    /// </summary>
    public class WallComment : Comment
    {
        /// <summary>
        /// Indicates if the current user can edit the comment.
        /// </summary>
        [JsonProperty("can_edit")]
        public bool CanEdit { get; set; }

        /// <summary>
        /// Indicates if the current user can delete the comment.
        /// </summary>
        [JsonProperty("can_delete")]
        public bool CanDelete { get; set; }

        /// <summary>
        /// The ID of the wall post to which the comment belongs.
        /// </summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        /// <summary>
        /// The ID of the owner of the wall post.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Information about the comment thread.
        /// </summary>
        [JsonProperty("thread")]
        public CommentThread? Thread { get; set; }

        /// <summary>
        /// Information about likes on the comment.
        /// </summary>
        [JsonProperty("likes")]
        public WallPostLikes? Likes { get; set; }

        /// <summary>
        /// Indicates if the comment is from the post author.
        /// </summary>
        [JsonProperty("is_from_post_author")]
        public bool? IsFromPostAuthor { get; set; }
    }
}