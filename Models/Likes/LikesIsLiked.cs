using Newtonsoft.Json;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.Likes
{
    /// <summary>
    /// Represents the response from a likes.isLiked API call.
    /// </summary>
    public class LikesIsLiked
    {
        /// <summary>
        /// Indicates if the user has liked the object.
        /// </summary>
        [JsonProperty("liked")]
        [JsonConverter(typeof(BoolToIntConverter))]
        public bool Liked { get; set; }

        /// <summary>
        /// Indicates if the user has reposted the object.
        /// </summary>
        [JsonProperty("copied")]
        [JsonConverter(typeof(BoolToIntConverter))]
        public bool Copied { get; set; }
    }
}
