using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Wall
{
    /// <summary>
    /// Represents the ID of a wall post.
    /// </summary>
    public class WallPostId
    {
        /// <summary>
        /// The post ID.
        /// </summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}
