using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents the response from <c>account.saveInterestsInfo</c>.
    /// Used in <see cref="OpenVkNetApi.Methods.Account.SaveInterestsInfoAsync"/>.
    /// </summary>
    public class AccountSaveInterests
    {
        /// <summary>
        /// Indicates if the information was changed (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("changed")]
        public int Changed { get; set; }
    }
}
