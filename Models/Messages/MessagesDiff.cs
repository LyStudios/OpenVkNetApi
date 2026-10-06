using System.Collections.Generic;
using Newtonsoft.Json;
using OpenVkNetApi.Models.Groups;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents the result of an incremental messages synchronization (<c>messages.getDiff</c>).
    /// </summary>
    public class MessagesDiff
    {
        /// <summary>
        /// Current server Unix timestamp.
        /// </summary>
        [JsonProperty("server_time")]
        public long ServerTime { get; set; }

        /// <summary>
        /// Current protocol version on the server.
        /// </summary>
        [JsonProperty("server_version")]
        public int ServerVersion { get; set; }

        /// <summary>
        /// Indicates whether local message cache should be invalidated.
        /// </summary>
        [JsonProperty("invalidate_all")]
        public bool InvalidateAll { get; set; }

        /// <summary>
        /// Information about changed conversations.
        /// </summary>
        [JsonProperty("conversations_info")]
        public List<ConversationDiffInfo> ConversationsInfo { get; set; } = new List<ConversationDiffInfo>();

        /// <summary>
        /// User profiles associated with the conversations.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User> Profiles { get; set; } = new List<User>();

        /// <summary>
        /// Communities associated with the conversations.
        /// </summary>
        [JsonProperty("groups")]
        public List<Group> Groups { get; set; } = new List<Group>();

        /// <summary>
        /// Overall message counters.
        /// </summary>
        [JsonProperty("counters")]
        public MessagesCounters Counters { get; set; }

        /// <summary>
        /// Folder collections.
        /// </summary>
        [JsonProperty("folders")]
        public Collection<MessageFolder> Folders { get; set; }

        /// <summary>
        /// Long Poll credentials for live updates.
        /// </summary>
        [JsonProperty("credentials")]
        public LongPollServerInfo Credentials { get; set; }
    }
}
