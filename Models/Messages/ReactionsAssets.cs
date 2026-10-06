using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents reaction assets metadata returned by <c>messages.getReactionsAssets</c>.
    /// </summary>
    public class ReactionsAssets
    {
        /// <summary>
        /// Version of the assets.
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }

        /// <summary>
        /// Assets catalog.
        /// </summary>
        [JsonProperty("assets")]
        public List<string> Assets { get; set; } = new List<string>();

        /// <summary>
        /// Override assets catalog.
        /// </summary>
        [JsonProperty("override_assets")]
        public List<string> OverrideAssets { get; set; } = new List<string>();

        /// <summary>
        /// Supported reaction IDs.
        /// </summary>
        [JsonProperty("reaction_ids")]
        public List<int> ReactionIds { get; set; } = new List<int>();
    }
}
