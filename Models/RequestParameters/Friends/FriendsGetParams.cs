using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Models.RequestParameters.Friends
{
    /// <summary>
    /// Parameters for the friends.get method.
    /// </summary>
    public class FriendsGetParams
    {
        /// <summary>
        /// ID of the user whose friends list to return.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; } = 0;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [JsonProperty("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// Offset needed to return a specific subset of friends.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of friends to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 100;
    }
}
