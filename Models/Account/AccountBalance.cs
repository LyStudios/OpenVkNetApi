using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents the response from <c>account.getBalance</c> or <c>account.sendVotes</c>.
    /// Used in <see cref="OpenVkNetApi.Methods.Account.GetBalanceAsync"/> and <see cref="OpenVkNetApi.Methods.Account.SendVotesAsync"/>.
    /// </summary>
    public class AccountBalance
    {
        /// <summary>
        /// The current balance of votes.
        /// </summary>
        [JsonProperty("votes")]
        public int Votes { get; set; }
    }
}
