using Newtonsoft.Json;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents the response from <c>account.saveInterestsInfo</c>.
    /// Used in <see cref="OpenVkNetApi.Methods.Account.SaveInterestsInfoAsync"/>.
    /// </summary>
    public class AccountSaveInterests
    {
        /// <summary>
        /// Indicates if the information was changed.
        /// </summary>
        [JsonProperty("changed")]
        [JsonConverter(typeof(BoolToIntConverter))]
        public bool Changed { get; set; }
    }
}
