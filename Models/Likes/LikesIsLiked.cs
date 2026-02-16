using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Likes
{
    /// <summary>
    /// Represents the response from a likes.isLiked API call.
    /// </summary>
    public class LikesIsLiked
    {
        /// <summary>
        /// Indicates if the user has liked the object (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("liked")]
        public int Liked { get; set; }

        /// <summary>
        /// Indicates if the user has reposted the object (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("copied")]
        public int Copied { get; set; }
    }
}
