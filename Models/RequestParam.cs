using Newtonsoft.Json;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents a single request parameter entry returned in an API error payload.
    /// </summary>
    public class RequestParam
    {
        /// <summary>
        /// The parameter name/key.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// The parameter value.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
