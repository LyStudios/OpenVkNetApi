using Newtonsoft.Json;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Auth
{
    /// <summary>
    /// Represents exchange token info for multi-account login.
    /// </summary>
    public class ExchangeTokenInfo
    {
        /// <summary>
        /// Notification counter for the account.
        /// </summary>
        [JsonProperty("notification_counter")]
        public int NotificationCounter { get; set; }

        /// <summary>
        /// User profile information.
        /// </summary>
        [JsonProperty("profile")]
        public User Profile { get; set; }
    }
}
