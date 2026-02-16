using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Status
{
    /// <summary>
    /// Represents a user's status, which can include text and an audio file.
    /// </summary>
    public class UserStatus
    {
        /// <summary>
        /// The text of the user's status.
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The audio file set as the user's status.
        /// </summary>
        [JsonProperty("audio")]
        public Audio.Audio? Audio { get; set; }
    }
}
