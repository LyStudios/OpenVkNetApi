using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

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
        [ApiParameter("user_ids")]
        public string UserIds { get; set; } = "0";

        /// <summary>
        /// A comma-separated list of additional fields to return for each user.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of users to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 100;
    }
}
