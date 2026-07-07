using Newtonsoft.Json;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents likes information for a photo.
    /// </summary>
    public class PhotoLikes
    {
        /// <summary>
        /// The number of likes.
        /// </summary>
        [JsonProperty("likes")]
        public int? Likes { get; set; }

        /// <summary>
        /// Indicates if the current user has liked the photo.
        /// </summary>
        [JsonProperty("user_likes")]
        [JsonConverter(typeof(BoolToIntConverter))]
        public bool? UserLikes { get; set; }

        /// <summary>
        /// Indicates if the current user can like the photo.
        /// </summary>
        [JsonProperty("can_like")]
        [JsonConverter(typeof(BoolToIntConverter))]
        public bool? CanLike { get; set; }

        /// <summary>
        /// Indicates if the current user can publish the like.
        /// </summary>
        [JsonProperty("can_publish")]
        [JsonConverter(typeof(BoolToIntConverter))]
        public bool? CanPublish { get; set; }
    }
}
