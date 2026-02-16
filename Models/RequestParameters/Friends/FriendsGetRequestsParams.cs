using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Models.RequestParameters.Friends
{
    /// <summary>
    /// Parameters for the friends.getRequests method.
    /// </summary>
    public class FriendsGetRequestsParams
    {
        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [JsonProperty("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// 1 to return outgoing friend requests, 0 for incoming.
        /// </summary>
        [JsonProperty("out")]
        public int Out { get; set; } = 0;

        /// <summary>
        /// Offset needed to return a specific subset of requests.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of requests to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 100;

        /// <summary>
        /// 1 to return extended information about users.
        /// </summary>
        [JsonProperty("extended")]
        public int Extended { get; set; } = 0;
    }
}
