using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Wall
{
    /// <summary>
    /// Represents the result of a wall.createComment API call.
    /// </summary>
    public class WallCreateComment
    {
        /// <summary>
        /// The ID of the created comment.
        /// </summary>
        [JsonProperty("comment_id")]
        public int CommentId { get; set; }

        /// <summary>
        /// A stack of parent comment IDs for replies. Currently always empty in PHP.
        /// </summary>
        [JsonProperty("parents_stack")]
        public List<object>? ParentsStack { get; set; }
    }
}
