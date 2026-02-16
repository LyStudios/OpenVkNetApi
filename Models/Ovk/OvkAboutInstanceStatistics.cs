using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Ovk
{
    /// <summary>
    /// Represents various statistics about the OpenVK instance.
    /// </summary>
    public class OvkAboutInstanceStatistics
    {
        /// <summary>
        /// The total number of users on the instance.
        /// </summary>
        [JsonProperty("users_count")]
        public int UsersCount { get; set; }

        /// <summary>
        /// The number of online users.
        /// </summary>
        [JsonProperty("online_users_count")]
        public int OnlineUsersCount { get; set; }

        /// <summary>
        /// The number of active users.
        /// </summary>
        [JsonProperty("active_users_count")]
        public int ActiveUsersCount { get; set; }

        /// <summary>
        /// The total number of groups on the instance.
        /// </summary>
        [JsonProperty("groups_count")]
        public int GroupsCount { get; set; }

        /// <summary>
        /// The total number of wall posts.
        /// </summary>
        [JsonProperty("wall_posts_count")]
        public int WallPostsCount { get; set; }
    }
}
