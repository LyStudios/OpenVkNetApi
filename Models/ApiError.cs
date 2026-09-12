using Newtonsoft.Json;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents an error returned by the OpenVK API.
    /// Used for deserializing standard API error responses.
    /// </summary>
    public class ApiError
    {
        /// <summary>
        /// The API error code.
        /// </summary>
        [JsonProperty("error_code")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// A description of the error.
        /// </summary>
        [JsonProperty("error_msg")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The OAuth / authorization error code string (e.g., "need_validation", "invalid_grant").
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        /// The OAuth / authorization error description.
        /// </summary>
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
        
        /// <summary>
        /// The request parameters that caused the error.
        /// </summary>
        [JsonProperty("request_params")]
        public object RequestParams { get; set; }

        /// <summary>
        /// Returns a string representation of the API error.
        /// </summary>
        /// <returns>A string in the format "Code: Message".</returns>
        public override string ToString()
        {
            var msg = !string.IsNullOrEmpty(ErrorMessage) ? ErrorMessage : (!string.IsNullOrEmpty(ErrorDescription) ? ErrorDescription : Error);
            return $"{ErrorCode}: {msg}";
        }
    }
}
