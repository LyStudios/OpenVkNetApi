using System.Collections.Generic;
using Newtonsoft.Json;
using OpenVkNetApi.Models.Groups;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Apps
{
    /// <summary>
    /// Represents the mini apps catalog result.
    /// </summary>
    public class MiniAppsCatalog
    {
        /// <summary>
        /// Total number of apps.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Catalog items.
        /// </summary>
        [JsonProperty("items")]
        public List<MiniAppItem> Items { get; set; }

        /// <summary>
        /// List of mini apps.
        /// </summary>
        [JsonProperty("apps")]
        public List<MiniAppItem> Apps { get; set; }

        /// <summary>
        /// Profiles related to apps.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User> Profiles { get; set; }

        /// <summary>
        /// Communities related to apps.
        /// </summary>
        [JsonProperty("groups")]
        public List<Group> Groups { get; set; }
    }
}
