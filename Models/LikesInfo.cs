using Newtonsoft.Json;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents likes metadata on a resource.
    /// </summary>
    public class LikesInfo
    {
        /// <summary>
        /// The total number of likes.
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Indicates if the current user has liked this resource.
        /// </summary>
        [JsonProperty("user_likes")]
        public bool? UserLikes { get; set; }

        /// <summary>
        /// Indicates if the current user can like this resource.
        /// </summary>
        [JsonProperty("can_like")]
        public bool? CanLike { get; set; }

        /// <summary>
        /// Indicates if the current user can publish this resource.
        /// </summary>
        [JsonProperty("can_publish")]
        public bool? CanPublish { get; set; }
    }
}
