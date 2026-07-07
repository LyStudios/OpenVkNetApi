using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Attachments;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents a post on a wall or in the newsfeed.
    /// </summary>
    public class Post
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
        /// The ID of the owner of the wall or post.
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
        public string PostType { get; set; }

        /// <summary>
        /// The text content of the post.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// A list of previous posts in the copy history (for reposts).
        /// </summary>
        [JsonProperty("copy_history")]
        public List<Post> CopyHistory { get; set; }

        /// <summary>
        /// Indicates if the current user can edit the post.
        /// </summary>
        [JsonProperty("can_edit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// Indicates if the current user can delete the post.
        /// </summary>
        [JsonProperty("can_delete")]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// Indicates if the current user can pin the post.
        /// </summary>
        [JsonProperty("can_pin")]
        public bool? CanPin { get; set; }

        /// <summary>
        /// Indicates if the current user can archive the post.
        /// </summary>
        [JsonProperty("can_archive")]
        public bool? CanArchive { get; set; }

        /// <summary>
        /// Indicates if the post is archived.
        /// </summary>
        [JsonProperty("is_archived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        /// Indicates if the post is pinned.
        /// </summary>
        [JsonProperty("is_pinned")]
        public bool? IsPinned { get; set; }

        /// <summary>
        /// Indicates if the post contains explicit content.
        /// </summary>
        [JsonProperty("is_explicit")]
        public bool? IsExplicit { get; set; }

        /// <summary>
        /// A list of attachments to the post (e.g., photos, videos, documents).
        /// </summary>
        [JsonProperty("attachments")]
        [JsonConverter(typeof(AttachmentJsonConverter))]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Information about the source of the post.
        /// </summary>
        [JsonProperty("post_source")]
        public object PostSource { get; set; }

        /// <summary>
        /// Information about comments on the post.
        /// </summary>
        [JsonProperty("comments")]
        public CommentsInfo Comments { get; set; }

        /// <summary>
        /// Information about likes on the post.
        /// </summary>
        [JsonProperty("likes")]
        public LikesInfo Likes { get; set; }

        /// <summary>
        /// Information about reposts of the post.
        /// </summary>
        [JsonProperty("reposts")]
        public RepostsInfo Reposts { get; set; }

        /// <summary>
        /// Copyright information for the post.
        /// </summary>
        [JsonProperty("copyright")]
        public object Copyright { get; set; }

        /// <summary>
        /// The ID of the user who signed the post (if applicable).
        /// </summary>
        [JsonProperty("signer_id")]
        public object SignerId { get; set; }

        /// <summary>
        /// Indicates if this is the final post in a series.
        /// </summary>
        [JsonProperty("final_post")]
        public object FinalPost { get; set; }

        /// <summary>
        /// Geographic information attached to the post.
        /// </summary>
        [JsonProperty("geo")]
        public Geo Geo { get; set; }

        /// <summary>
        /// The type of newsfeed item (usually "post").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The ID of the news source (user or community).
        /// </summary>
        [JsonProperty("source_id")]
        public int? SourceId { get; set; }

        /// <summary>
        /// Alternate or legacy post ID.
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }
    }
}
