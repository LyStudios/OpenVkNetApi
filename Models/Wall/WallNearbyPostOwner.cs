using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Wall
{
    /// <summary>
    /// Represents the owner of a nearby wall post.
    /// </summary>
    public class WallNearbyPostOwner
    {
        /// <summary>
        /// The domain of the owner's page.
        /// </summary>
        [JsonProperty("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// The URL of the owner's 50px profile photo.
        /// </summary>
        [JsonProperty("photo_50")]
        public string? Photo50 { get; set; }

        /// <summary>
        /// The name of the owner.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Indicates if the owner is verified.
        /// </summary>
        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }
}
