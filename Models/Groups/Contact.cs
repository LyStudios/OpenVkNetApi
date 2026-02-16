using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Groups
{
    /// <summary>
    /// Represents a contact person for a group.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// The user ID of the contact person.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// A description of the contact's role or position.
        /// </summary>
        [JsonProperty("desc")]
        public string? Desc { get; set; }
    }
}
