using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Comments
{
    /// <summary>
    /// Represents a comment thread.
    /// </summary>
    public class CommentThread
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