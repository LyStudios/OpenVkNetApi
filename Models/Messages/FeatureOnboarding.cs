using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents onboarding feature entries returned by <c>messages.getFeatureOnboarding</c>.
    /// </summary>
    public class FeatureOnboarding
    {
        /// <summary>
        /// List of onboarding entries.
        /// </summary>
        [JsonProperty("onboarding_entries")]
        public List<string> OnboardingEntries { get; set; } = new List<string>();
    }
}
