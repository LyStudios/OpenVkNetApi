using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Models.Execute;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for executing custom scripts and aggregated procedures.
    /// Encapsulates the <c>execute.*</c> methods of the OpenVK API.
    /// </summary>
    public class Execute : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Execute"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Execute(OpenVkApi api) : base(api, "execute") { }

        /// <summary>
        /// Returns aggregated user information including profile, account info, counters, and initial newsfeed in a single request.
        /// </summary>
        /// <param name="fields">A list of user fields to return.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="ExecuteUserInfo"/> object with combined user data.</returns>
        public async Task<ExecuteUserInfo> GetUserInfoAsync(UserFields fields = UserFields.None, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .ToDictionary();

            return await GetAsync<ExecuteUserInfo>("getUserInfo", parameters, ct);
        }

        /// <summary>
        /// An Easter egg method returning "котлетки".
        /// </summary>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A string response.</returns>
        [AllowAnonymous]
        public async Task<string> NuggetsAsync(CancellationToken ct = default)
        {
            return await GetAsync<string>("nuggets", null, ct);
        }

        /// <summary>
        /// Executes a custom VKScript code string on the OpenVK server.
        /// </summary>
        /// <typeparam name="T">The type of the expected result.</typeparam>
        /// <param name="code">The VKScript code string to execute (e.g. <c>"return API.users.get({'user_ids': 1});"</c>).</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The result of the VKScript execution deserialized to <typeparamref name="T"/>.</returns>
        public async Task<T> ExecuteAsync<T>(string code, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("code", code)
                .ToDictionary();

            return await _api.CallApiPostAsync<T>("execute", parameters, ct);
        }

        /// <summary>
        /// Executes a custom VKScript code string on the OpenVK server and returns the raw JSON token.
        /// </summary>
        /// <param name="code">The VKScript code string to execute.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Newtonsoft.Json.Linq.JToken"/> representing the execution result.</returns>
        public async Task<Newtonsoft.Json.Linq.JToken> ExecuteAsync(string code, CancellationToken ct = default)
        {
            return await ExecuteAsync<Newtonsoft.Json.Linq.JToken>(code, ct);
        }

        /// <summary>
        /// Executes a stored server procedure on the OpenVK server (e.g., <c>execute.getNewsfeedSmart</c>).
        /// </summary>
        /// <typeparam name="T">The type of the expected result.</typeparam>
        /// <param name="procedureName">The procedure name to execute.</param>
        /// <param name="parameters">Parameters to pass to the procedure.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The result of the procedure deserialized to <typeparamref name="T"/>.</returns>
        public async Task<T> ProcedureAsync<T>(string procedureName, object parameters = null, CancellationToken ct = default)
        {
            return await PostAsync<T>(procedureName, parameters, ct);
        }
    }
}
