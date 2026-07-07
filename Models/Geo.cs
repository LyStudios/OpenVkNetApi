using Newtonsoft.Json;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents geographic information attached to a resource.
    /// </summary>
    public class Geo
    {
        /// <summary>
        /// The type of geo target (e.g., "point").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Comma-separated coordinates (latitude, longitude).
        /// </summary>
        [JsonProperty("coordinates")]
        public string Coordinates { get; set; }

        /// <summary>
        /// The name of the geographic location or address.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Information about the place.
        /// </summary>
        [JsonProperty("place")]
        public string Place { get; set; }
    }
}
