using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Ovk
{
    /// <summary>
    /// Represents the response from the ovk.test API method.
    /// </summary>
    public class OvkTest
    {
        /// <summary>
        /// Indicates if the API call was authorized.
        /// </summary>
        [JsonProperty("authorized")]
        public bool Authorized { get; set; }

        /// <summary>
        /// The authentication method used, if authorized.
        /// </summary>
        [JsonProperty("auth_with")]
        public string? AuthWith { get; set; }

        /// <summary>
        /// The version of the API.
        /// </summary>
        [JsonProperty("version")]
        public string? Version { get; set; }
    }
}
