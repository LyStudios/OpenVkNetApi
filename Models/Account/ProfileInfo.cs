using Newtonsoft.Json;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents the response from <c>account.getProfileInfo</c>.
    /// Used in <see cref="OpenVkNetApi.Methods.Account.GetProfileInfoAsync"/>.
    /// Contains detailed information about a user's profile.
    /// </summary>
    public class ProfileInfo : UserCommon
    {
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
        /// The audio file set as the user's status.
        /// </summary>
        [JsonProperty("audio_status")]
        public Audio.Audio? AudioStatus { get; set; }
    }
}
