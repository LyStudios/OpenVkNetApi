using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents settings of a group chat conversation.
    /// </summary>
    public class ChatSettings
    {
        /// <summary>
        /// Gets or sets the number of members in the conversation.
        /// </summary>
        [JsonProperty("members_count")]
        public int MembersCount { get; set; }

        /// <summary>
        /// Gets or sets the title of the conversation.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the pinned message in the conversation, if any.
        /// </summary>
        [JsonProperty("pinned_message")]
        public Message PinnedMessage { get; set; }

        /// <summary>
        /// Gets or sets the state of the current user in the chat (in, left, kicked).
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the chat photo URLs (e.g. photo_50, photo_100, photo_200).
        /// </summary>
        [JsonProperty("photo")]
        public Dictionary<string, string> Photo { get; set; }

        /// <summary>
        /// Gets or sets the IDs of currently active members in the chat.
        /// </summary>
        [JsonProperty("active_ids")]
        public List<int> ActiveIds { get; set; }

        /// <summary>
        /// Gets or sets the admin/owner ID of the chat.
        /// </summary>
        [JsonProperty("admin_id")]
        public int? AdminId { get; set; }
    }
}
