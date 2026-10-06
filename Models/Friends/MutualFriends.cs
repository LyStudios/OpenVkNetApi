using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Friends
{
    /// <summary>
    /// Represents mutual friends information for a user.
    /// </summary>
    public class MutualFriends
    {
        /// <summary>
        /// Target user identifier.
        /// </summary>
        [JsonProperty("target_uid")]
        public int TargetUid { get; set; }

        /// <summary>
        /// List of mutual friends user identifiers.
        /// </summary>
        [JsonProperty("common_friends")]
        public List<int> CommonFriends { get; set; }

        /// <summary>
        /// Total number of mutual friends.
        /// </summary>
        [JsonProperty("common_count")]
        public int? CommonCount { get; set; }
    }
}
