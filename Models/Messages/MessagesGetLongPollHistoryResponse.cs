using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents the response from a messages.getLongPollHistory API call.
    /// </summary>
    public class MessagesGetLongPollHistoryResponse
    {
        /// <summary>
        /// A list of history events. The exact type of objects is not strictly defined.
        /// </summary>
        [JsonProperty("history")]
        public List<object>? History { get; set; }

        /// <summary>
        /// A collection of new messages.
        /// </summary>
        [JsonProperty("messages")]
        public Collection<Message>? Messages { get; set; }

        /// <summary>
        /// A list of user profiles related to the history events.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User>? Profiles { get; set; }

        /// <summary>
        /// The new 'pts' value to be used in the next long poll request.
        /// </summary>
        [JsonProperty("new_pts")]
        public int NewPts { get; set; }
    }
}
