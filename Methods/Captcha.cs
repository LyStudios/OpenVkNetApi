using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for testing and interacting with captcha mechanisms.
    /// Encapsulates the <c>captcha.*</c> methods of the OpenVK API.
    /// </summary>
    public class Captcha : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Captcha"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Captcha(OpenVkApi api) : base(api, "captcha") { }

        /// <summary>
        /// Forces a captcha verification response from the server for testing purposes.
        /// </summary>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A raw response from the server.</returns>
        [AllowAnonymous]
        public async Task<JToken> ForceAsync(CancellationToken ct = default)
        {
            return await GetAsync<JToken>("force", null, ct);
        }
    }
}
