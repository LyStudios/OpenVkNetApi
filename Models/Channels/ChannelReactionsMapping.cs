using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Channels
{
    /// <summary>
    /// Represents channel reaction mapping data.
    /// </summary>
    public class ChannelReactionsMapping
    {
        /// <summary>
        /// Reaction mappings.
        /// </summary>
        [JsonProperty("mapping")]
        public List<string> Mapping { get; set; }
    }
}
