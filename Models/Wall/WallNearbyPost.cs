using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Wall
{
    /// <summary>
    /// Represents a nearby wall post with geographic information.
    /// </summary>
    public class WallNearbyPost
    {
        /// <summary>
        /// The text of the post.
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The URL of the post.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The date when the post was created, as an HTML string.
        /// </summary>
        [JsonProperty("created")]
        public string? Created { get; set; }

        /// <summary>
        /// Information about the post owner.
        /// </summary>
        [JsonProperty("owner")]
        public WallNearbyPostOwner? Owner { get; set; }

        /// <summary>
        /// Geographic information about the post.
        /// </summary>
        [JsonProperty("geo")]
        public WallNearbyPostGeo? Geo { get; set; }

        /// <summary>
        /// The distance to the post from the current location.
        /// </summary>
        [JsonProperty("distance")]
        public float Distance { get; set; }
    }
}
