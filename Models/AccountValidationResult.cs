using Newtonsoft.Json;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents the result of an account validation request.
    /// </summary>
    public class AccountValidationResult
    {
        /// <summary>
        /// The validation flow name (e.g., "need_password").
        /// </summary>
        [JsonProperty("flow_name")]
        public string FlowName { get; set; }

        /// <summary>
        /// The session ID for validation.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; set; }
    }
}
