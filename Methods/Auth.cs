using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
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
    }
}
