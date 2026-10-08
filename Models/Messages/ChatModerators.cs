using System.Collections.Generic;
using Newtonsoft.Json;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents the moderators returned by <c>messages.getChatModerators</c>.
    /// </summary>
    public class ChatModerators
    {
        /// <summary>
        /// Gets or sets the ID of the chat owner/creator.
        /// </summary>
        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the number of moderators in the chat.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the list of moderator user IDs.
        /// </summary>
        [JsonProperty("items")]
        public List<long> Items { get; set; }

        /// <summary>
        /// Gets or sets the list of moderator user IDs (alias for Items).
        /// </summary>
        [JsonProperty("moderator_ids")]
        public List<long> ModeratorIds { get; set; }

        /// <summary>
        /// Gets or sets extended profile information for moderators and owner, if requested.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User> Profiles { get; set; }
    }
}
