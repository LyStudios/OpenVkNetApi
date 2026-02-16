using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Models.RequestParameters.Users
{
    /// <summary>
    /// Parameters for the users.getFollowers method.
    /// </summary>
    public class UsersGetFollowersParams
    {
        /// <summary>
        /// ID of the user whose followers to return.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [JsonProperty("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// Offset needed to return a specific subset of followers.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of followers to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 100;
    }
}
