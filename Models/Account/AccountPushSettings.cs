using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents push notification settings for an account.
    /// </summary>
    public class AccountPushSettings
    {
        /// <summary>
        /// Unix timestamp until which notifications are disabled (or -1/0).
        /// </summary>
        [JsonProperty("disabled_until")]
        public long? DisabledUntil { get; set; }

        /// <summary>
        /// Whether notification sound is enabled.
        /// </summary>
        [JsonProperty("sound")]
        public int? Sound { get; set; }

        /// <summary>
        /// Additional granular push notification settings.
        /// </summary>
        [JsonProperty("settings")]
        public PushSettings Settings { get; set; }
    }
}
