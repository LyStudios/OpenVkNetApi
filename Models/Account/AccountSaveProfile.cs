using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents the response from <c>account.saveProfileInfo</c>.
    /// Used in <see cref="OpenVkNetApi.Methods.Account.SaveProfileInfoAsync"/>.
    /// Contains information about the result of a profile save operation.
    /// </summary>
    public class AccountSaveProfile
    {
        /// <summary>
        /// Indicates if the profile information was changed (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("changed")]
        public int Changed { get; set; }
        
        /// <summary>
        /// Information about a name change request, if one was created.
        /// </summary>
        [JsonProperty("name_request")]
        public AccountNameRequest? NameRequest { get; set; }
    }
}
