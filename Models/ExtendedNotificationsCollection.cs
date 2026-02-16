using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Account;
using OpenVkNetApi.Models.Groups;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents a collection of notifications that can include extended information about users and groups.
    /// </summary>
    /// <typeparam name="T">The type of the notification items.</typeparam>
    public class ExtendedNotificationsCollection<T> : NotificationsCollection<T> where T : class
    {
        /// <summary>
        /// A list of user profiles mentioned in the notifications.
        /// </summary>
        [JsonProperty("profiles")]
        public List<ProfileInfo>? Profiles { get; set; }

        /// <summary>
        /// A list of group profiles mentioned in the notifications.
        /// </summary>
        [JsonProperty("groups")]
        public List<Group>? Groups { get; set; }
    }
}
