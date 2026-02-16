using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Account
{
    /// <summary>
    /// Represents the result of a name change request.
    /// </summary>
    public class AccountNameRequest
    {
        /// <summary>
        /// The request ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        
        /// <summary>
        /// The status of the request.
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }
        
        /// <summary>
        /// The requested first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// The requested last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string? LastName { get; set; }
    }
}
