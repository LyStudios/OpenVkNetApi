using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents the response from <c>account.getOvkSettings</c>.
    /// Used in <see cref="OpenVkNetApi.Methods.Account.GetOvkSettingsAsync"/>.
    /// </summary>
    public class AccountOvkSettings
    {
        /// <summary>
        /// The style of avatars (e.g., round/square).
        /// </summary>
        [JsonProperty("avatar_style")]
        public int AvatarStyle { get; set; }
        
        /// <summary>
        /// The theme or style used by the user.
        /// </summary>
        [JsonProperty("style")]
        public string? Style { get; set; }
        
        /// <summary>
        /// Indicates if the rating is shown.
        /// </summary>
        [JsonProperty("show_rating")]
        public bool ShowRating { get; set; }
        
        /// <summary>
        /// The user's tolerance level for NSFW content.
        /// </summary>
        [JsonProperty("nsfw_tolerance")]
        public int NsfwTolerance { get; set; }
        
        /// <summary>
        /// The post view style (e.g., classic/microblog).
        /// </summary>
        [JsonProperty("post_view")]
        public string? PostView { get; set; }
        
        /// <summary>
        /// The user's default main page (e.g., newsfeed/profile).
        /// </summary>
        [JsonProperty("main_page")]
        public string? MainPage { get; set; }
    }
}
