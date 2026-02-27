using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

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
        [ApiParameter("user_id")]
        public int UserId { get; set; } = 0;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// Offset needed to return a specific subset of friends.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of friends to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 100;
    }
}
