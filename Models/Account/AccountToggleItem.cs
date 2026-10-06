using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents an individual feature toggle in the account settings.
    /// </summary>
    public class AccountToggleItem
    {
        /// <summary>
        /// Feature toggle name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Optional configuration value for the feature toggle.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
