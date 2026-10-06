using System.Collections.Generic;
using Newtonsoft.Json;
using OpenVkNetApi.Models.Groups;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Execute
{
    /// <summary>
    /// Represents newsfeed data returned in execute.getUserInfo.
    /// </summary>
    public class ExecuteNewsfeedData
    {
        /// <summary>
        /// Gets or sets feed type (e.g. "top").
        /// </summary>
        [JsonProperty("feed_type")]
        public string FeedType { get; set; }

        /// <summary>
        /// Refresh timeout for recent news in milliseconds.
        /// </summary>
        [JsonProperty("refresh_timeout_recent")]
        public int RefreshTimeoutRecent { get; set; }

        /// <summary>
        /// Refresh timeout for top news in milliseconds.
        /// </summary>
        [JsonProperty("refresh_timeout_top")]
        public int RefreshTimeoutTop { get; set; }

        /// <summary>
        /// Refresh timeout for recommended news in milliseconds.
        /// </summary>
        [JsonProperty("refresh_timeout_recommended")]
        public int RefreshTimeoutRecommended { get; set; }

        /// <summary>
        /// Newsfeed posts items.
        /// </summary>
        [JsonProperty("items")]
        public List<Post> Items { get; set; }

        /// <summary>
        /// Profiles involved in newsfeed items.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User> Profiles { get; set; }

        /// <summary>
        /// Communities involved in newsfeed items.
        /// </summary>
        [JsonProperty("groups")]
        public List<Group> Groups { get; set; }
    }
}
