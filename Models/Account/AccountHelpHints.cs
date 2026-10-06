using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents help hints for account sections.
    /// </summary>
    public class AccountHelpHints
    {
        /// <summary>
        /// Total number of hints.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// List of hint identifiers or texts.
        /// </summary>
        [JsonProperty("hints")]
        public List<string> Hints { get; set; }

        /// <summary>
        /// List of hint items.
        /// </summary>
        [JsonProperty("items")]
        public List<string> Items { get; set; }
    }
}
