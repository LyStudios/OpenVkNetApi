using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Account;
using OpenVkNetApi.Models.Groups;

namespace OpenVkNetApi.Models.Wall
{
    /// <summary>
    /// Represents the response from a wall.get API call.
    /// </summary>
    public class WallGet
    {
        /// <summary>
        /// The total number of posts on the wall.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// A list of wall posts.
        /// </summary>
        [JsonProperty("items")]
        public List<WallPost>? Items { get; set; }

        /// <summary>
        /// A list of user profiles related to the posts, if extended information was requested.
        /// </summary>
        [JsonProperty("profiles")]
        public List<ProfileInfo>? Profiles { get; set; }

        /// <summary>
        /// A list of group profiles related to the posts, if extended information was requested.
        /// </summary>
        [JsonProperty("groups")]
        public List<Group>? Groups { get; set; }

        /// <summary>
        /// The offset for the next page of results for pagination.
        /// </summary>
        [JsonProperty("next_from")]
        public string? NextFrom { get; set; }
    }
}
