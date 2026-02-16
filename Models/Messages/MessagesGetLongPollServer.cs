using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents the server and credentials for a long poll connection.
    /// </summary>
    public class MessagesGetLongPollServer
    {
        /// <summary>
        /// The secret key for the long poll connection.
        /// </summary>
        [JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The server address for the long poll connection.
        /// </summary>
        [JsonProperty("server")]
        public string? Server { get; set; }

        /// <summary>
        /// The timestamp to start polling from.
        /// </summary>
        [JsonProperty("ts")]
        public int Ts { get; set; }

        /// <summary>
        /// The persistent timestamp value.
        /// </summary>
        [JsonProperty("pts")]
        public int? Pts { get; set; }
    }
}
