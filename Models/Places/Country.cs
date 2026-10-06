using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Places
{
    /// <summary>
    /// Represents a country object in the OpenVK API.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Gets or sets the country ID.
        /// </summary>
        [JsonProperty("cid")]
        public int Cid { get; set; }

        /// <summary>
        /// Gets or sets the country name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
