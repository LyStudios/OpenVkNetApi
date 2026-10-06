using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Auth
{
    /// <summary>
    /// Represents the exchange token result.
    /// </summary>
    public class ExchangeTokenResult
    {
        /// <summary>
        /// Generated exchange token string.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
