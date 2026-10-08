using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents preview information for a chat accessible via an invite link.
    /// </summary>
    public class ChatPreview
    {
        /// <summary>
        /// Gets or sets the chat admin user ID.
        /// </summary>
        [JsonProperty("admin_id")]
        public long AdminId { get; set; }

        /// <summary>
        /// Gets or sets member user IDs in the chat.
        /// </summary>
        [JsonProperty("members")]
        public List<long> Members { get; set; }

        /// <summary>
        /// Gets or sets total member count.
        /// </summary>
        [JsonProperty("members_count")]
        public int MembersCount { get; set; }

        /// <summary>
        /// Gets or sets the chat title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets chat photo URLs.
        /// </summary>
        [JsonProperty("photo")]
        public Dictionary<string, string> Photo { get; set; }

        /// <summary>
        /// Gets or sets the local chat ID.
        /// </summary>
        [JsonProperty("local_id")]
        public long LocalId { get; set; }
    }
}
