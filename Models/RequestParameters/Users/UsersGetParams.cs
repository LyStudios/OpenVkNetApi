using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Users
{
    /// <summary>
    /// Parameters for the users.get method.
    /// </summary>
    public class UsersGetParams
    {
        /// <summary>
        /// A comma-separated list of user IDs to return. "0" for the current user.
        /// </summary>
        [JsonProperty("user_ids")]
        public string UserIds { get; set; } = "0";

        /// <summary>
        /// A comma-separated list of additional fields to return for each user.
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; } = "";

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of users to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 100;
    }
}
