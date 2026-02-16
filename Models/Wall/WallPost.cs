using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Attachments;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.Wall
{
    /// <summary>
    /// Represents a wall post.
    /// </summary>
    public class WallPost
    {
        /// <summary>
        /// The post ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The ID of the author of the post.
        /// </summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        /// <summary>
        /// The ID of the owner of the wall.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// The date when the post was published, in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// The type of the post (e.g., "post", "copy", "reply").
        /// </summary>
        [JsonProperty("post_type")]
        public string? PostType { get; set; }

        /// <summary>
        /// The text content of the post.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// A list of previous posts in the copy history (for reposts).
        /// </summary>
        [JsonProperty("copy_history")]
        public List<WallPost>? CopyHistory { get; set; }

        /// <summary>
        /// Indicates if the current user can edit the post.
        /// </summary>
        [JsonProperty("can_edit")]
        public bool CanEdit { get; set; }

        /// <summary>
        /// Indicates if the current user can delete the post.
        /// </summary>
        [JsonProperty("can_delete")]
        public bool CanDelete { get; set; }

        /// <summary>
        /// Indicates if the current user can pin the post.
        /// </summary>
        [JsonProperty("can_pin")]
        public bool CanPin { get; set; }

        /// <summary>
        /// Indicates if the current user can archive the post.
        /// </summary>
        [JsonProperty("can_archive")]
        public bool CanArchive { get; set; }

        /// <summary>
        /// Indicates if the post is archived.
        /// </summary>
        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        /// <summary>
        /// Indicates if the post is pinned.
        /// </summary>
        [JsonProperty("is_pinned")]
        public bool IsPinned { get; set; }

        /// <summary>
        /// Indicates if the post contains explicit content.
        /// </summary>
        [JsonProperty("is_explicit")]
        public bool IsExplicit { get; set; }

        /// <summary>
        /// A list of attachments to the post (e.g., photos, videos, documents).
        /// </summary>
        [JsonProperty("attachments")]
        [JsonConverter(typeof(AttachmentJsonConverter))]
        public List<Attachment>? Attachments { get; set; }

        /// <summary>
        /// Information about the source of the post.
        /// </summary>
        [JsonProperty("post_source")]
        public object? PostSource { get; set; }

        /// <summary>
        /// Information about comments on the post.
        /// </summary>
        [JsonProperty("comments")]
        public WallPostComments? Comments { get; set; }

        /// <summary>
        /// Information about likes on the post.
        /// </summary>
        [JsonProperty("likes")]
        public WallPostLikes? Likes { get; set; }

        /// <summary>
        /// Information about reposts of the post.
        /// </summary>
        [JsonProperty("reposts")]
        public WallPostReposts? Reposts { get; set; }

        /// <summary>
        /// Copyright information for the post.
        /// </summary>
        [JsonProperty("copyright")]
        public object? Copyright { get; set; }

        /// <summary>
        /// The ID of the user who signed the post (if applicable).
        /// </summary>
        [JsonProperty("signer_id")]
        public int? SignerId { get; set; }

        /// <summary>
        /// Indicates if this is the final post in a series (e.g., for multipart posts).
        /// </summary>
        [JsonProperty("final_post")]
        public int? FinalPost { get; set; }

        /// <summary>
        /// Geographic information attached to the post.
        /// </summary>
        [JsonProperty("geo")]
        public object? Geo { get; set; }
    }

    /// <summary>
    /// Represents comment information for a wall post.
    /// </summary>
    public class WallPostComments
    {
        /// <summary>
        /// The total number of comments.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Indicates if the current user can post comments.
        /// </summary>
        [JsonProperty("can_post")]
        public int CanPost { get; set; }
    }

    /// <summary>
    /// Represents like information for a wall post.
    /// </summary>
    public class WallPostLikes
    {
        /// <summary>
        /// The total number of likes.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Indicates if the current user has liked this post (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("user_likes")]
        public int UserLikes { get; set; }

        /// <summary>
        /// Indicates if the current user can like this post (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("can_like")]
        public int CanLike { get; set; }

        /// <summary>
        /// Indicates if the current user can publish this like (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("can_publish")]
        public int CanPublish { get; set; }
    }

    /// <summary>
    /// Represents repost information for a wall post.
    /// </summary>
    public class WallPostReposts
    {
        /// <summary>
        /// The total number of reposts.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Indicates if the current user has reposted this post (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("user_reposted")]
        public int UserReposted { get; set; }
    }
}
