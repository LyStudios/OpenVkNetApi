using Newtonsoft.Json;
using OpenVkNetApi.Models.Groups;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Ovk
{
    /// <summary>
    /// Represents detailed information about the OpenVK instance.
    /// </summary>
    public class OvkAboutInstance
    {
        /// <summary>
        /// Statistics about the instance.
        /// </summary>
        [JsonProperty("statistics")]
        public OvkAboutInstanceStatistics? Statistics { get; set; }

        /// <summary>
        /// A collection of administrators of the instance.
        /// </summary>
        [JsonProperty("administrators")]
        public Collection<User>? Administrators { get; set; }

        /// <summary>
        /// A collection of popular groups on the instance.
        /// </summary>
        [JsonProperty("popular_groups")]
        public Collection<Group>? PopularGroups { get; set; }

        /// <summary>
        /// A collection of external links associated with the instance.
        /// </summary>
        [JsonProperty("links")]
        public Collection<OvkAboutInstanceLink>? Links { get; set; }
    }
}
