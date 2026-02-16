using Newtonsoft.Json;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents the response from <c>account.getProfileInfo</c>.
    /// Used in <see cref="OpenVkNetApi.Methods.Account.GetProfileInfoAsync"/>.
    /// Contains detailed information about a user's profile.
    /// </summary>
    public class ProfileInfo : UserBase
    {
        /// <summary>
        /// The user's nickname.
        /// </summary>
        [JsonProperty("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// URL of the 200px profile photo.
        /// </summary>
        [JsonProperty("photo_200")]
        public string? Photo200 { get; set; }
        
        /// <summary>
        /// Indicates if this is a service account.
        /// </summary>
        [JsonProperty("is_service_account")]
        public bool? IsServiceAccount { get; set; }
        
        /// <summary>
        /// Indicates if the profile is verified.
        /// </summary>
        [JsonProperty("is_verified")]
        public bool? IsVerified { get; set; }
        
        /// <summary>
        /// The verification status message.
        /// </summary>
        [JsonProperty("verification_status")]
        public string? VerificationStatus { get; set; }
        
        /// <summary>
        /// The user's home town.
        /// </summary>
        [JsonProperty("home_town")]
        public string? HomeTown { get; set; }
        
        /// <summary>
        /// The user's status message.
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }
        
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
        /// The user's phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string? Phone { get; set; }
        
        /// <summary>
        /// The user's relationship status.
        /// </summary>
        [JsonProperty("relation")]
        public int? Relation { get; set; }
        
        /// <summary>
        /// The user's screen name (short name).
        /// </summary>
        [JsonProperty("screen_name")]
        public string? ScreenName { get; set; }
        
        /// <summary>
        /// The user's gender/sex.
        /// </summary>
        [JsonProperty("sex")]
        public int? Sex { get; set; }
        
        /// <summary>
        /// The audio file set as the user's status.
        /// </summary>
        [JsonProperty("audio_status")]
        public Audio.Audio? AudioStatus { get; set; }
    }
}
