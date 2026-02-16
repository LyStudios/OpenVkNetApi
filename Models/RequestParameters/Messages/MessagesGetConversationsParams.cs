using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the messages.getConversations method.
    /// </summary>
    public class MessagesGetConversationsParams
    {
        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of conversations to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 20;

        /// <summary>
        /// Filter for conversations (e.g., "all", "unread", "important").
        /// </summary>
        [JsonProperty("filter")]
        public string Filter { get; set; } = "all";

        /// <summary>
        /// 1 to return extended information about users and groups.
        /// </summary>
        [JsonProperty("extended")]
        public int Extended { get; set; } = 0;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [JsonProperty("fields")]
        public UserFields Fields { get; set; } = UserFields.None;
    }
}
