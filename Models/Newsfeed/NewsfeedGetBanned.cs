using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Users;
using OpenVkNetApi.Models.Groups;

namespace OpenVkNetApi.Models.Newsfeed
{
    /// <summary>
    /// Represents the response from a newsfeed.getBanned API call.
    /// </summary>
    public class NewsfeedGetBanned
    {
        /// <summary>
        /// The total number of banned items.
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// A list of banned users and/or communities.
        /// </summary>
        [JsonProperty("items")]
        public List<object>? Items { get; set; }

        /// <summary>
        /// A list of banned groups.
        /// </summary>
        [JsonProperty("groups")]
        public List<Group>? Groups { get; set; }

        /// <summary>
        /// A list of banned user IDs.
        /// </summary>
        [JsonProperty("members")]
        public List<int>? Members { get; set; }

        /// <summary>
        /// A list of user profiles related to the banned items.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User>? Profiles { get; set; }
    }
}
