using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents the response from <c>account.getInfo</c>.
    /// Used in <see cref="OpenVkNetApi.Methods.Account.GetInfoAsync"/>.
    /// Contains various settings for the current user's account.
    /// </summary>
    public class AccountInfo
    {
        /// <summary>
        /// Indicates if two-factor authentication is required.
        /// </summary>
        [JsonProperty("2fa_required")]
        public int TwoFaRequired { get; set; }
        
        /// <summary>
        /// The user's country code.
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; }
        
        /// <summary>
        /// Indicates if the user is from the European Union.
        /// </summary>
        [JsonProperty("eu_user")]
        public bool EuUser { get; set; }
        
        /// <summary>
        /// Indicates if HTTPS is required for API requests.
        /// </summary>
        [JsonProperty("https_required")]
        public int HttpsRequired { get; set; }
        
        /// <summary>
        /// An introductory flag.
        /// </summary>
        [JsonProperty("intro")]
        public int Intro { get; set; }
        
        /// <summary>
        /// A flag for community comments.
        /// </summary>
        [JsonProperty("community_comments")]
        public bool CommunityComments { get; set; }
        
        /// <summary>
        /// Indicates if live streaming is enabled.
        /// </summary>
        [JsonProperty("is_live_streaming_enabled")]
        public bool IsLiveStreamingEnabled { get; set; }
        
        /// <summary>
        /// Indicates if new live streaming features are enabled.
        /// </summary>
        [JsonProperty("is_new_live_streaming_enabled")]
        public bool IsNewLiveStreamingEnabled { get; set; }
        
        /// <summary>
        /// The user's language ID.
        /// </summary>
        [JsonProperty("lang")]
        public int Lang { get; set; }
        
        /// <summary>
        /// A flag indicating if wall replies are disabled.
        /// </summary>
        [JsonProperty("no_wall_replies")]
        public int NoWallReplies { get; set; }
        
        /// <summary>
        /// A flag for default post settings.
        /// </summary>
        [JsonProperty("own_posts_default")]
        public int OwnPostsDefault { get; set; }
    }
}
