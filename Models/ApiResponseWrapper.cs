using Newtonsoft.Json;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// An internal wrapper for standard OpenVK API responses.
    /// Contains the 'response' field with the actual data.
    /// </summary>
    /// <typeparam name="T">The type of the API response data.</typeparam>
    internal class ApiResponseWrapper<T>
    {
        /// <summary>
        /// The API response data (the main content of the request).
        /// </summary>
        [JsonProperty("response")]
        public T Response { get; set; } = default!;
    }
}
