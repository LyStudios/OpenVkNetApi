using Newtonsoft.Json;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents reposts metadata on a resource.
    /// </summary>
    public class RepostsInfo
    {
        /// <summary>
        /// The total number of reposts.
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Indicates if the current user has reposted this resource.
        /// </summary>
        [JsonProperty("user_reposted")]
        public bool? UserReposted { get; set; }
    }
}
