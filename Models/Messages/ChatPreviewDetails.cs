using System.Collections.Generic;
using Newtonsoft.Json;
using OpenVkNetApi.Models.Groups;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents the chat preview details returned by <c>messages.getChatPreview</c>.
    /// </summary>
    public class ChatPreviewDetails
    {
        /// <summary>
        /// Gets or sets the chat preview details.
        /// </summary>
        [JsonProperty("preview")]
        public ChatPreview Preview { get; set; }

        /// <summary>
        /// Gets or sets extended profile information for users, if requested.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User> Profiles { get; set; }

        /// <summary>
        /// Gets or sets extended group information, if requested.
        /// </summary>
        [JsonProperty("groups")]
        public List<Group> Groups { get; set; }
    }
}
