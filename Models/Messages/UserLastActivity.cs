using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents information about the last activity and online status of a user.
    /// </summary>
    public class UserLastActivity
    {
        /// <summary>
        /// Gets or sets a value indicating whether the user is online (1) or offline (0).
        /// </summary>
        [JsonProperty("online")]
        public int Online { get; set; }

        /// <summary>
        /// Gets or sets the Unix timestamp of the user's last action.
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }
    }
}
