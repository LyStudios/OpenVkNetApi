using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Places
{
    /// <summary>
    /// Represents a city object in the OpenVK API.
    /// </summary>
    public class City
    {
        /// <summary>
        /// Gets or sets the city ID.
        /// </summary>
        [JsonProperty("cid")]
        public int Cid { get; set; }

        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
