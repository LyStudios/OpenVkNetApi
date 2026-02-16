using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Wall
{
    /// <summary>
    /// Represents geographic information attached to a wall post.
    /// </summary>
    public class WallNearbyPostGeo
    {
        /// <summary>
        /// The type of geographic object (e.g., "point").
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The coordinates of the geographic object (e.g., "55.755826 37.6173").
        /// </summary>
        [JsonProperty("coordinates")]
        public string? Coordinates { get; set; }

        /// <summary>
        /// Information about the place. Can be a complex object.
        /// </summary>
        [JsonProperty("place")]
        public object? Place { get; set; }
    }
}
