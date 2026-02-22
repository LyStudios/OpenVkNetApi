using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents information required to connect to the Long Poll server.
    /// </summary>
    public class LongPollServerInfo
    {
        /// <summary>
        /// Long Poll key.
        /// </summary>
        [JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Long Poll server URL.
        /// </summary>
        [JsonProperty("server")]
        public string? Server { get; set; }

        /// <summary>
        /// Timestamp for the Long Poll request. This is 'ts' from the server-side, and corresponds to 'new_pts' in history.
        /// </summary>
        [JsonProperty("ts")]
        public long Ts { get; set; }

        [JsonProperty("pts")]
        public long? Pts { get; set; }
    }
}
