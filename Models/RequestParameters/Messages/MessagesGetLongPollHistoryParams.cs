using OpenVkNetApi.Utils;

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
        [ApiParameter("ts")]
        public int Ts { get; set; } = -1;

        /// <summary>
        /// The number of characters to return from the message text.
        /// </summary>
        [ApiParameter("preview_length")]
        public int PreviewLength { get; set; } = 0;

        /// <summary>
        /// The maximum number of events to return.
        /// </summary>
        [ApiParameter("events_limit")]
        public int EventsLimit { get; set; } = 1000;

        /// <summary>
        /// The maximum number of messages to return.
        /// </summary>
        [ApiParameter("msgs_limit")]
        public int MsgsLimit { get; set; } = 1000;
    }
}
