using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Users
{
    /// <summary>
    /// Represents a city.
    /// </summary>
    public class City
    {
        /// <summary>
        /// The city ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The city title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
