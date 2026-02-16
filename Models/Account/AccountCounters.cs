using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents the response from <c>account.getCounters</c>.
    /// Used in <see cref="OpenVkNetApi.Methods.Account.GetCountersAsync"/>.
    /// Contains various counters for the current user.
    /// </summary>
    public class AccountCounters
    {
        /// <summary>
        /// Number of new friend requests.
        /// </summary>
        [JsonProperty("friends")]
        public int? Friends { get; set; }
        
        /// <summary>
        /// Number of unread notifications.
        /// </summary>
        [JsonProperty("notifications")]
        public int? Notifications { get; set; }
        
        /// <summary>
        /// Number of unread private messages.
        /// </summary>
        [JsonProperty("messages")]
        public int? Messages { get; set; }
    }
}
