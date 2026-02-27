using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// Base class for all API method sections (e.g., Account, Audio, Photos).
    /// Provides common functionality for making API calls through the <see cref="OpenVkApi"/> instance.
    /// </summary>
    public abstract class MethodBase
    {
        /// <summary>
        /// Reference to the main OpenVK API instance.
        /// </summary>
        protected readonly OpenVkApi _api;

        /// <summary>
        /// The category name for this method section (e.g., "account", "audio", "photos").
        /// </summary>
        protected readonly string _category;

        /// <summary>
        /// Initializes a new instance of the <see cref="MethodBase"/> class.
        /// </summary>
        /// <param name="api">The main API instance.</param>
        /// <param name="category">The category name for this method section.</param>
        protected MethodBase(OpenVkApi api, string category)
        {
            _api = api;
            _category = category;
        }

        /// <summary>
        /// Executes a GET API call.
        /// </summary>
        /// <typeparam name="T">The type of the expected API response.</typeparam>
        /// <param name="method">The API method name (e.g., <c>getProfileInfo</c>). If it contains a dot, it's treated as a full method name.</param>
        /// <param name="parameters">An object containing the request parameters.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>The deserialized API response of type <typeparamref name="T"/>.</returns>
        protected Task<T> GetAsync<T>(string method, object? parameters = null, CancellationToken cancellationToken = default)
        {
            var fullMethodName = method.Contains(".") ? method : $"{_category}.{method}";
            Dictionary<string, string>? dictParameters = null;
            if (parameters != null)
            {
                if (parameters is Dictionary<string, string> existingDict)
                {
                    dictParameters = existingDict;
                }
                else
                {
                    dictParameters = RequestParams.FromObject(parameters);
                }
            }
            return _api.CallApiAsync<T>(fullMethodName, dictParameters, cancellationToken);
        }

        /// <summary>
        /// Executes a POST API call.
        /// </summary>
        /// <typeparam name="T">The type of the expected API response.</typeparam>
        /// <param name="method">The API method name (e.g., <c>add</c>). If it contains a dot, it's treated as a full method name.</param>
        /// <param name="parameters">An object containing the request parameters.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>The deserialized API response of type <typeparamref name="T"/>.</returns>
        protected Task<T> PostAsync<T>(string method, object? parameters = null, CancellationToken cancellationToken = default)
        {
            var fullMethodName = method.Contains(".") ? method : $"{_category}.{method}";
            Dictionary<string, string>? dictParameters = null;
            if (parameters != null)
            {
                if (parameters is Dictionary<string, string> existingDict)
                {
                    dictParameters = existingDict;
                }
                else
                {
                    dictParameters = RequestParams.FromObject(parameters);
                }
            }
            return _api.CallApiPostAsync<T>(fullMethodName, dictParameters, cancellationToken);
        }
    }
}
