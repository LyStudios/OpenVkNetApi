using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Represents a user broadcasting audio.
    /// </summary>
    public sealed class BroadcastUser : BroadcastItem
    {
        /// <summary>
        /// Gets or sets the first name of the user.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Gets or sets the last name of the user.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; } = "";

        /// <summary>
        /// Gets or sets a value indicating whether the user's account is deactivated.
        /// </summary>
        [JsonProperty("deactivated")]
        public bool Deactivated { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user's profile is closed (private).
        /// </summary>
        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }
    }
}
