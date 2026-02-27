using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Account;
using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Models.RequestParameters.Account;
using OpenVkNetApi.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with user accounts.
    /// Encapsulates the <c>account.*</c> methods of the OpenVK API.
    /// </summary>
    public class Account : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        internal Account(OpenVkApi api) : base(api, "account") { }

        /// <summary>
        /// Gets the current user's profile information.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="ProfileInfo"/> object with profile data.</returns>
        public Task<ProfileInfo> GetProfileInfoAsync(CancellationToken cancellationToken = default)
        {
            return GetAsync<ProfileInfo>("getProfileInfo", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets information about the current account.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An <see cref="AccountInfo"/> object with account settings.</returns>
        public Task<AccountInfo> GetInfoAsync(CancellationToken cancellationToken = default)
        {
            return GetAsync<AccountInfo>("getInfo", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Sets the current user's status to online.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public Task<int> SetOnlineAsync(CancellationToken cancellationToken = default)
        {
            return GetAsync<int>("setOnline", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Sets the current user's status to offline.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public Task<int> SetOfflineAsync(CancellationToken cancellationToken = default)
        {
            return GetAsync<int>("setOffline", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets the permissions of the current application.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A bitmask representing the application's permissions.</returns>
        public Task<int> GetAppPermissionsAsync(CancellationToken cancellationToken = default)
        {
            return GetAsync<int>("getAppPermissions", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets various counters for the current user.
        /// </summary>
        /// <param name="filter">A comma-separated list of counter names to return (e.g., "friends,messages").</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An <see cref="AccountCounters"/> object with the requested counters.</returns>
        public Task<AccountCounters> GetCountersAsync(string filter = "", CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams().Add("filter", filter).ToDictionary();
            return GetAsync<AccountCounters>("getCounters", parameters, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Saves changes to the current user's profile information.
        /// </summary>
        /// <param name="params">An object with the profile data to save.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An <see cref="AccountSaveProfile"/> object with the result of the save operation.</returns>
        public Task<AccountSaveProfile> SaveProfileInfoAsync(SaveProfileInfoParams @params, CancellationToken cancellationToken = default)
        {
            return GetAsync<AccountSaveProfile>("saveProfileInfo", @params, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets the current user's account balance.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An <see cref="AccountBalance"/> object with balance information.</returns>
        public Task<AccountBalance> GetBalanceAsync(CancellationToken cancellationToken = default)
        {
            return GetAsync<AccountBalance>("getBalance", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets OpenVK-specific settings for the account.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An <see cref="AccountOvkSettings"/> object with OVK settings.</returns>
        public Task<AccountOvkSettings> GetOvkSettingsAsync(CancellationToken cancellationToken = default)
        {
            return GetAsync<AccountOvkSettings>("getOvkSettings", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Sends votes (internal currency) to another user.
        /// </summary>
        /// <param name="receiverId">The ID of the user to receive the votes.</param>
        /// <param name="value">The number of votes to send.</param>
        /// <param name="message">An optional message to include with the transfer.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An <see cref="AccountBalance"/> object with the updated balance.</returns>
        public Task<AccountBalance> SendVotesAsync(int receiverId, int value, string message = "", CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("receiver", receiverId)
                .Add("value", value)
                .Add("message", message)
                .ToDictionary();

            return GetAsync<AccountBalance>("sendVotes", parameters, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Bans a user.
        /// </summary>
        /// <param name="ownerId">The ID of the user to ban.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public Task<int> BanAsync(int ownerId, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams().Add("owner_id", ownerId).ToDictionary();
            return GetAsync<int>("ban", parameters, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Unbans a user.
        /// </summary>
        /// <param name="ownerId">The ID of the user to unban.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public Task<int> UnbanAsync(int ownerId, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams().Add("owner_id", ownerId).ToDictionary();
            return GetAsync<int>("unban", parameters, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets a list of banned users.
        /// </summary>
        /// <param name="offset">The offset for pagination.</param>
        /// <param name="count">The number of users to return.</param>
        /// <param name="fields">A comma-separated list of additional user fields to return.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{User}"/> of banned users.</returns>
        public Task<Collection<Models.Users.User>> GetBannedAsync(int offset = 0, int count = 100, UserFields fields = UserFields.None, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("offset", offset)
                .Add("count", count)
                .Add("fields", fields)
                .ToDictionary();

            return GetAsync<Collection<Models.Users.User>>("getBanned", parameters, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Saves changes to the user's interests.
        /// </summary>
        /// <param name="params">The parameters containing the interests information.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An <see cref="AccountSaveInterests"/> object with the result of the save operation.</returns>
        public Task<AccountSaveInterests> SaveInterestsInfoAsync(SaveInterestsInfoParams @params, CancellationToken cancellationToken = default)
        {
            return GetAsync<AccountSaveInterests>("saveInterestsInfo", @params, cancellationToken: cancellationToken);
        }
    }
}
