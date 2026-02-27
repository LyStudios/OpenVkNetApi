using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Groups
{
    /// <summary>
    /// Parameters for the groups.getMembers method.
    /// </summary>
    public class GroupsGetMembersParams
    {
        /// <summary>
        /// The group ID.
        /// </summary>
        [ApiParameter("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// Offset needed to return a specific subset of members.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of members to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;
    }
}
