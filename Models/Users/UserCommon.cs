using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Users
{
    /// <summary>
    /// Represents common user profile information.
    /// </summary>
    public class UserCommon : UserBase
    {
        /// <summary>
        /// The user's nickname.
        /// </summary>
        [JsonProperty("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// The user's screen name (short address).
        /// </summary>
        [JsonProperty("screen_name")]
        public string? ScreenName { get; set; }

        /// <summary>
        /// The user's gender (1 for female, 2 for male, 0 for unspecified).
        /// </summary>
        [JsonProperty("sex")]
        public int? Sex { get; set; }

        /// <summary>
        /// The user's birth date.
        /// </summary>
        [JsonProperty("bdate")]
        public string? Bdate { get; set; }

        /// <summary>
        /// The visibility of the user's birth date.
        /// </summary>
        [JsonProperty("bdate_visibility")]
        public int? BdateVisibility { get; set; }

        /// <summary>
        /// The user's status message.
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// URL of the 200x200px profile photo.
        /// </summary>
        [JsonProperty("photo_200")]
        public string? Photo200 { get; set; }
    }
}
