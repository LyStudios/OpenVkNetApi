using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Information about a single conversation change returned in <c>messages.getDiff</c>.
    /// </summary>
    public class ConversationDiffInfo
    {
        /// <summary>
        /// The conversation details.
        /// </summary>
        [JsonProperty("conversation")]
        public Conversation Conversation { get; set; }

        /// <summary>
        /// List of recent messages in this conversation.
        /// </summary>
        [JsonProperty("message")]
        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
