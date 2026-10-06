using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents server feature toggles and experiments for the account.
    /// </summary>
    public class AccountToggles
    {
        /// <summary>
        /// List of feature toggles.
        /// </summary>
        [JsonProperty("toggles")]
        public List<AccountToggleItem> Toggles { get; set; }

        /// <summary>
        /// Configuration schema version.
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }

        /// <summary>
        /// Active A/B test experiments.
        /// </summary>
        [JsonProperty("ab_tests")]
        public List<string> AbTests { get; set; }
    }
}
