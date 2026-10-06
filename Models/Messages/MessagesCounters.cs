using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents overall messaging counters returned by <c>messages.getCounters</c>.
    /// </summary>
    public class MessagesCounters
    {
        /// <summary>
        /// Total number of unread messages.
        /// </summary>
        [JsonProperty("messages")]
        public int Messages { get; set; }

        /// <summary>
        /// Total number of unread messages from unmuted chats.
        /// </summary>
        [JsonProperty("messages_unread_unmuted")]
        public int MessagesUnreadUnmuted { get; set; }

        /// <summary>
        /// Number of incoming message requests.
        /// </summary>
        [JsonProperty("message_requests")]
        public int MessageRequests { get; set; }

        /// <summary>
        /// Number of unread important messages.
        /// </summary>
        [JsonProperty("important")]
        public int Important { get; set; }

        /// <summary>
        /// Number of unanswered conversations.
        /// </summary>
        [JsonProperty("unanswered")]
        public int Unanswered { get; set; }

        /// <summary>
        /// Number of missed/unread calls.
        /// </summary>
        [JsonProperty("calls")]
        public int Calls { get; set; }

        /// <summary>
        /// Folder-specific counters.
        /// </summary>
        [JsonProperty("messages_folders")]
        public List<FolderCounter> Folders { get; set; } = new List<FolderCounter>();
    }
}
