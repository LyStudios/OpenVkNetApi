using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;
using System.Linq;
using System;

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
                    dictParameters = ToDictionary(parameters);
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
                    dictParameters = ToDictionary(parameters);
                }
            }
            return _api.CallApiPostAsync<T>(fullMethodName, dictParameters, cancellationToken);
        }

        /// <summary>
        /// Converts an object's properties into a dictionary of string key-value pairs,
        /// suitable for API request parameters. Handles Newtonsoft.Json.JsonPropertyAttribute for names.
        /// </summary>
        /// <param name="obj">The object to convert.</param>
        /// <returns>A dictionary of parameters.</returns>
        protected Dictionary<string, string> ToDictionary(object obj)
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var prop in obj.GetType().GetTypeInfo().DeclaredProperties)
            {
                var jsonPropertyAttribute = prop.GetCustomAttributes(typeof(Newtonsoft.Json.JsonPropertyAttribute), false)
                                                .Cast<Newtonsoft.Json.JsonPropertyAttribute>().FirstOrDefault();
                var key = jsonPropertyAttribute?.PropertyName ?? prop.Name;

                object? propValue = prop.GetValue(obj);

                if (propValue == null)
                {
                    continue; // Skip null values
                }

                // Handle enum flags with Description attributes
                if (prop.PropertyType.GetTypeInfo().IsEnum && prop.PropertyType.GetTypeInfo().IsDefined(typeof(System.FlagsAttribute), false))
                {
                    dictionary[key] = EnumHelper.GetEnumFlagsDescription((Enum)propValue);
                }
                else if (prop.PropertyType.GetTypeInfo().IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    // Handle Nullable<T> types
                    var underlyingType = Nullable.GetUnderlyingType(prop.PropertyType);
                    if (underlyingType != null && underlyingType.GetTypeInfo().IsEnum && underlyingType.GetTypeInfo().IsDefined(typeof(System.FlagsAttribute), false))
                    {
                        dictionary[key] = EnumHelper.GetEnumFlagsDescription((Enum)propValue);
                    }
                    else
                    {
                        dictionary[key] = propValue.ToString();
                    }
                }
                else if (prop.PropertyType == typeof(bool))
                {
                    // Convert bool to "1" or "0"
                    dictionary[key] = ((bool)propValue) ? "1" : "0";
                }
                else
                {
                    dictionary[key] = propValue.ToString();
                }
            }
            return dictionary;
        }
    }
}
