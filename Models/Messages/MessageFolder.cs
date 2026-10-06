using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents a custom dialog/message folder in OpenVK.
    /// </summary>
    public class MessageFolder
    {
        /// <summary>
        /// The folder identifier.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The folder type (e.g., "custom", "all", etc.).
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The title/name of the folder.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Peer IDs included in this folder.
        /// </summary>
        [JsonProperty("included_peer_ids")]
        public List<int> IncludedPeerIds { get; set; }

        /// <summary>
        /// Included lists for this folder.
        /// </summary>
        [JsonProperty("included_lists")]
        public List<int> IncludedLists { get; set; }

        /// <summary>
        /// Flags for folder attributes.
        /// </summary>
        [JsonProperty("flags")]
        public int Flags { get; set; }

        /// <summary>
        /// Random ID associated with the folder.
        /// </summary>
        [JsonProperty("random_id")]
        public int RandomId { get; set; }
    }
}
