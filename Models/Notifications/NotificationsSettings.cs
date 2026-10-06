using System.Collections.Generic;
using Newtonsoft.Json;
using OpenVkNetApi.Models.Groups;
using OpenVkNetApi.Models.Photos;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Notifications
{
    /// <summary>
    /// Represents notification settings and subscriptions.
    /// </summary>
    public class NotificationsSettings
    {
        /// <summary>
        /// Groups with notifications enabled.
        /// </summary>
        [JsonProperty("groups")]
        public List<Group> Groups { get; set; }

        /// <summary>
        /// Photos with notifications enabled.
        /// </summary>
        [JsonProperty("photos")]
        public List<Photo> Photos { get; set; }

        /// <summary>
        /// Profiles with notifications enabled.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User> Profiles { get; set; }
    }
}
