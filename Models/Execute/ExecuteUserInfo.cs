using Newtonsoft.Json;
using OpenVkNetApi.Models.Account;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Execute
{
    /// <summary>
    /// Represents the aggregated response from the execute.getUserInfo method.
    /// </summary>
    public class ExecuteUserInfo
    {
        /// <summary>
        /// Gets or sets the full user profile.
        /// </summary>
        [JsonProperty("profile")]
        public User Profile { get; set; }

        /// <summary>
        /// Gets or sets general account info and settings.
        /// </summary>
        [JsonProperty("info")]
        public AccountInfo Info { get; set; }

        /// <summary>
        /// Gets or sets user counters (friends, messages, notifications, etc.).
        /// </summary>
        [JsonProperty("counters")]
        public AccountCounters Counters { get; set; }

        /// <summary>
        /// Gets or sets newsfeed initial data.
        /// </summary>
        [JsonProperty("newsfeed")]
        public ExecuteNewsfeedData Newsfeed { get; set; }

        /// <summary>
        /// Gets or sets current server timestamp in Unix time.
        /// </summary>
        [JsonProperty("time")]
        public long Time { get; set; }

        /// <summary>
        /// Indicates if buying votes is allowed.
        /// </summary>
        [JsonProperty("allow_buy_votes")]
        public int AllowBuyVotes { get; set; }

        /// <summary>
        /// Indicates if HTML games are shown.
        /// </summary>
        [JsonProperty("show_html_games")]
        public int ShowHtmlGames { get; set; }

        /// <summary>
        /// Gets or sets default audio player identifier string.
        /// </summary>
        [JsonProperty("defaultAudioPlayer")]
        public string DefaultAudioPlayer { get; set; }
    }
}
