using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

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
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// 1 to return outgoing friend requests, 0 for incoming.
        /// </summary>
        [ApiParameter("out")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Out { get; set; } = false;

        /// <summary>
        /// Offset needed to return a specific subset of requests.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of requests to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 100;

        /// <summary>
        /// 1 to return extended information about users.
        /// </summary>
        [ApiParameter("extended")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Extended { get; set; } = false;
    }
}
