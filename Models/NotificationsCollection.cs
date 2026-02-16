using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents a collection of notifications, which includes the timestamp of the last viewed notification.
    /// </summary>
    /// <typeparam name="T">The type of notification items.</typeparam>
    public class NotificationsCollection<T> : Collection<T> where T : class
    {
        /// <summary>
        /// The Unix timestamp of the last viewed notification.
        /// </summary>
        [JsonProperty("last_viewed")]
        public long? LastViewed { get; set; }
    }
}
