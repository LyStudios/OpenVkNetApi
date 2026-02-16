using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Users
{
    /// <summary>
    /// Base information about a user. Includes common fields across user-related models.
    /// </summary>
    public class UserBase
    {
        /// <summary>
        /// The user's ID.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The user's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// The user's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string? LastName { get; set; }
    }
}
