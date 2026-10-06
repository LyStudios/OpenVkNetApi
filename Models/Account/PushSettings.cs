using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents granular push notification category settings.
    /// </summary>
    public class PushSettings
    {
        /// <summary>
        /// Push settings for private messages.
        /// </summary>
        [JsonProperty("msg")]
        public List<string> Messages { get; set; }

        /// <summary>
        /// Push settings for chat messages.
        /// </summary>
        [JsonProperty("chat")]
        public List<string> Chat { get; set; }

        /// <summary>
        /// Push settings for likes.
        /// </summary>
        [JsonProperty("like")]
        public List<string> Like { get; set; }

        /// <summary>
        /// Push settings for replies.
        /// </summary>
        [JsonProperty("reply")]
        public List<string> Reply { get; set; }

        /// <summary>
        /// Push settings for comments.
        /// </summary>
        [JsonProperty("comment")]
        public List<string> Comment { get; set; }

        /// <summary>
        /// Push settings for mentions.
        /// </summary>
        [JsonProperty("mention")]
        public List<string> Mention { get; set; }

        /// <summary>
        /// Push settings for friend requests.
        /// </summary>
        [JsonProperty("friend")]
        public List<string> Friend { get; set; }
    }
}
