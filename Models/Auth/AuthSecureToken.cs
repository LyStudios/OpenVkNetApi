using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Auth
{
    /// <summary>
    /// Represents a secure authorization token.
    /// </summary>
    public class AuthSecureToken
    {
        /// <summary>
        /// Access token string.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// Secret key.
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}
