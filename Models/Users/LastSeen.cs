using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Users
{
    /// <summary>
    /// Represents information about when a user was last seen online.
    /// </summary>
    public class LastSeen
    {
        /// <summary>
        /// The platform from which the user was last seen (e.g., mobile, web).
        /// </summary>
        [JsonProperty("platform")]
        public int? Platform { get; set; }

        /// <summary>
        /// The time when the user was last seen, in Unix time.
        /// </summary>
        [JsonProperty("time")]
        public long? Time { get; set; }
    }
}
