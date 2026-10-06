using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents badges settings for the account.
    /// </summary>
    public class AccountBadgesSettings
    {
        /// <summary>
        /// Indicates whether badges are enabled.
        /// </summary>
        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// List of badge items.
        /// </summary>
        [JsonProperty("items")]
        public List<string> Items { get; set; }
    }
}
