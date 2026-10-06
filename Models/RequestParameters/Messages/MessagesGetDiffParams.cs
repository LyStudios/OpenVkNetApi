using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the <c>messages.getDiff</c> method.
    /// </summary>
    public class MessagesGetDiffParams
    {
        /// <summary>
        /// Last known timestamp from previous sync or Long Poll.
        /// </summary>
        [ApiParameter("ts")]
        public long Ts { get; set; } = 0;

        /// <summary>
        /// Long Poll version (usually 3 or 19).
        /// </summary>
        [ApiParameter("lp_version")]
        public int LpVersion { get; set; } = 3;

        /// <summary>
        /// Maximum number of events to return.
        /// </summary>
        [ApiParameter("events_limit")]
        public int EventsLimit { get; set; } = 1000;

        /// <summary>
        /// Maximum number of messages to return.
        /// </summary>
        [ApiParameter("msgs_limit")]
        public int MsgsLimit { get; set; } = 1000;

        /// <summary>
        /// Highest known message ID.
        /// </summary>
        [ApiParameter("max_msg_id")]
        public int MaxMsgId { get; set; } = 0;
    }
}
