using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Users
{
    /// <summary>
    /// Represents a custom field in a user's profile.
    /// </summary>
    public class CustomField
    {
        /// <summary>
        /// The type of the custom field.
        /// </summary>
        [JsonProperty("type")]
        public int? Type { get; set; }
        /// <summary>
        /// The name of the custom field.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
        /// <summary>
        /// The text value of the custom field.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }
    }
}
