using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Account;
using OpenVkNetApi.Models.Groups;

namespace OpenVkNetApi.Models.Notifications
{
    /// <summary>
    /// Represents the result of notifications.fetch.
    /// </summary>
    public class NotificationsFetch
    {
        /// <summary>
        /// A list of notification items.
        /// </summary>
        [JsonProperty("items")]
        public List<Notification> Items { get; set; }

        /// <summary>
        /// A list of user profiles mentioned in the notifications.
        /// </summary>
        [JsonProperty("profiles")]
        public List<ProfileInfo> Profiles { get; set; }

        /// <summary>
        /// A list of group profiles mentioned in the notifications.
        /// </summary>
        [JsonProperty("groups")]
        public List<Group> Groups { get; set; }

        /// <summary>
        /// The next last ID for pagination.
        /// </summary>
        [JsonProperty("next_last_id")]
        public string NextLastId { get; set; }

        /// <summary>
        /// The new last ID.
        /// </summary>
        [JsonProperty("new_lastId")]
        public string NewLastId { get; set; }
    }
}
