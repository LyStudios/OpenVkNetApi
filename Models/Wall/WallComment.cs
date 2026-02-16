using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Attachments;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.Wall
{
    /// <summary>
    /// Represents a comment on a wall post.
    /// </summary>
    public class WallComment
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
        /// The text of the comment.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }

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
        /// A stack of parent comment IDs for replies.
        /// </summary>
        [JsonProperty("parents_stack")]
        public List<object>? ParentsStack { get; set; }

        /// <summary>
        /// A list of attachments to the comment.
        /// </summary>
        [JsonProperty("attachments")]
        [JsonConverter(typeof(AttachmentJsonConverter))]
        public List<Attachment>? Attachments { get; set; }

        /// <summary>
        /// Information about the comment thread.
        /// </summary>
        [JsonProperty("thread")]
        public WallCommentThread? Thread { get; set; }

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

    /// <summary>
    /// Represents a comment thread.
    /// </summary>
    public class WallCommentThread
    {
        /// <summary>
        /// The number of comments in the thread.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// A list of nested comments.
        /// </summary>
        [JsonProperty("items")]
        public List<object>? Items { get; set; }

        /// <summary>
        /// Indicates if the current user can post comments in this thread.
        /// </summary>
        [JsonProperty("can_post")]
        public bool CanPost { get; set; }

        /// <summary>
        /// Indicates if a reply button should be shown.
        /// </summary>
        [JsonProperty("show_reply_button")]
        public bool ShowReplyButton { get; set; }

        /// <summary>
        /// Indicates if groups can post comments in this thread.
        /// </summary>
        [JsonProperty("groups_can_post")]
        public bool GroupsCanPost { get; set; }
    }
}
