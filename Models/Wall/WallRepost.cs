using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Wall
{
    /// <summary>
    /// Represents the result of a wall.repost API call.
    /// </summary>
    public class WallRepost
    {
        /// <summary>
        /// Indicates if the repost operation was successful (1 for success).
        /// </summary>
        [JsonProperty("success")]
        public int Success { get; set; }

        /// <summary>
        /// The ID of the created repost.
        /// </summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        /// <summary>
        /// A pretty ID for the repost (e.g., "owner_id_post_id").
        /// </summary>
        [JsonProperty("pretty_id")]
        public string? PrettyId { get; set; }

        /// <summary>
        /// The total number of reposts for the original post.
        /// </summary>
        [JsonProperty("reposts_count")]
        public int RepostsCount { get; set; }

        /// <summary>
        /// The total number of likes for the original post.
        /// </summary>
        [JsonProperty("likes_count")]
        public int LikesCount { get; set; }
    }
}
