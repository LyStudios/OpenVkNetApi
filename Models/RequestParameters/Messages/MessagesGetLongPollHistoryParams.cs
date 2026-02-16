using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the messages.getLongPollHistory method.
    /// </summary>
    public class MessagesGetLongPollHistoryParams
    {
        /// <summary>
        /// Last event ID (from previous long poll response).
        /// </summary>
        [JsonProperty("ts")]
        public int Ts { get; set; } = -1;

        /// <summary>
        /// The number of characters to return from the message text.
        /// </summary>
        [JsonProperty("preview_length")]
        public int PreviewLength { get; set; } = 0;

        /// <summary>
        /// The maximum number of events to return.
        /// </summary>
        [JsonProperty("events_limit")]
        public int EventsLimit { get; set; } = 1000;

        /// <summary>
        /// The maximum number of messages to return.
        /// </summary>
        [JsonProperty("msgs_limit")]
        public int MsgsLimit { get; set; } = 1000;
    }
}
