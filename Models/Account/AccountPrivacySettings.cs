using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents privacy settings of the account.
    /// </summary>
    public class AccountPrivacySettings
    {
        /// <summary>
        /// Available privacy sections.
        /// </summary>
        [JsonProperty("sections")]
        public List<string> Sections { get; set; }

        /// <summary>
        /// Specific privacy settings keys.
        /// </summary>
        [JsonProperty("settings")]
        public List<string> Settings { get; set; }

        /// <summary>
        /// Supported privacy categories.
        /// </summary>
        [JsonProperty("supported_categories")]
        public List<string> SupportedCategories { get; set; }

        /// <summary>
        /// Recommended closed profile settings.
        /// </summary>
        [JsonProperty("recommended_closed_profile_settings")]
        public List<string> RecommendedClosedProfileSettings { get; set; }

        /// <summary>
        /// Whether deprecated story privacy options are disabled.
        /// </summary>
        [JsonProperty("story_privacy_is_deprecated_options_disabled")]
        public bool StoryPrivacyIsDeprecatedOptionsDisabled { get; set; }
    }
}
