using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Models.RequestParameters.Wall
{
    /// <summary>
    /// Parameters for the wall.getComments method.
    /// </summary>
    public class WallGetCommentsParams
    {
        /// <summary>
        /// ID of the post owner.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// ID of the post.
        /// </summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        /// <summary>
        /// True to return the 'likes' object.
        /// </summary>
        [JsonProperty("need_likes")]
        public bool NeedLikes { get; set; } = true;

        /// <summary>
        /// Offset needed to return a specific subset of comments.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of comments to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [JsonProperty("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// Sort order of comments ("asc" or "desc").
        /// </summary>
        [JsonProperty("sort")]
        public string Sort { get; set; } = "asc";

        /// <summary>
        /// True to return extended information about users who posted comments.
        /// </summary>
        [JsonProperty("extended")]
        public bool Extended { get; set; } = false;
    }
}
