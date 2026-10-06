using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Auth;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with authentication.
    /// Encapsulates the <c>auth.*</c> methods of the OpenVK API.
    /// </summary>
    public class Auth : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Auth(OpenVkApi api) : base(api, "auth") { }

        /// <summary>
        /// Validates an account and returns the required authentication flow.
        /// </summary>
        /// <param name="login">An optional login or phone number to validate.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="AccountValidationResult"/> object.</returns>
        [AllowAnonymous]
        public async Task<AccountValidationResult> ValidateAccountAsync(string login = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("login", login)
                .ToDictionary();

            return await GetAsync<AccountValidationResult>("validateAccount", parameters, ct);
        }

        /// <summary>
        /// Obtains a secure token.
        /// </summary>
        [AllowAnonymous]
        public async Task<AuthSecureToken> GetTokenSecureAsync(string nonce = null, int? apiId = null, string clientId = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("nonce", nonce)
                .Add("api_id", apiId)
                .Add("client_id", clientId)
                .ToDictionary();

            return await GetAsync<AuthSecureToken>("getTokenSecure", parameters, ct);
        }

        /// <summary>
        /// Obtains a session securely via user credentials.
        /// </summary>
        [AllowAnonymous]
        public async Task<AuthSecureSession> GetSessionSecureAsync(string login = null, string password = null, int? apiId = null, string clientId = null, string code = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("login", login)
                .Add("password", password)
                .Add("api_id", apiId)
                .Add("client_id", clientId)
                .Add("code", code)
                .ToDictionary();

            return await PostAsync<AuthSecureSession>("getSessionSecure", parameters, ct);
        }

        /// <summary>
        /// Returns information about exchange tokens.
        /// </summary>
        public async Task<List<ExchangeTokenInfo>> GetExchangeTokensInfoAsync(string exchangeTokens = "", int targetAppId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("exchange_tokens", exchangeTokens)
                .Add("target_app_id", targetAppId)
                .ToDictionary();

            return await GetAsync<List<ExchangeTokenInfo>>("getExchangeTokensInfo", parameters, ct);
        }

        /// <summary>
        /// Generates an exchange token for cross-app authorization.
        /// </summary>
        public async Task<ExchangeTokenResult> GetExchangeTokenAsync(string exchangeTokens = "", int intermediate = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("exchange_tokens", exchangeTokens)
                .Add("intermediate", intermediate)
                .ToDictionary();

            return await GetAsync<ExchangeTokenResult>("getExchangeToken", parameters, ct);
        }
    }
}
