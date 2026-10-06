using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Auth
{
    /// <summary>
    /// Represents the result of a secure session authorization.
    /// </summary>
    public class AuthSecureSession
    {
        /// <summary>
        /// Authorization status.
        /// </summary>
        [JsonProperty("auth")]
        public string Auth { get; set; }

        /// <summary>
        /// User ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// User ID alias.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Session / token string.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; set; }

        /// <summary>
        /// Secret key.
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}
