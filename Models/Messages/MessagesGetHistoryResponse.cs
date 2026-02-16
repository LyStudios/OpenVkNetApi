using Newtonsoft.Json;
using OpenVkNetApi.Models.Users;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents the response from a messages.getHistory API call.
    /// </summary>
    public class MessagesGetHistoryResponse : Collection<Message>
    {
        /// <summary>
        /// A list of user profiles, if 'extended' was set to true.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User>? Profiles { get; set; }
    }
}
