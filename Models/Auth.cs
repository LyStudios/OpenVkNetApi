using Newtonsoft.Json;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents the OpenVK API response for an authorization request.
    /// Returned by <see cref="OpenVkApi.AuthorizeAsync"/>.
    /// </summary>
    public class Auth
    {
        /// <summary>
        /// The access token used for making authorized requests.
        /// </summary>
        [JsonProperty("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// The lifetime of the token in seconds.
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// The ID of the user who owns the access token.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Indicates if the token is stale.
        /// </summary>
        [JsonProperty("is_stale")]
        public bool IsStale { get; set; }

        /// <summary>
        /// A secret key, if returned by the server.
        /// </summary>
        [JsonProperty("secret")]
        public string? Secret { get; set; }
    }
}
