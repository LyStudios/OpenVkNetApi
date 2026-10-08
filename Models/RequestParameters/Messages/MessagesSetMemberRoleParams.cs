using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the <c>messages.setMemberRole</c> method.
    /// </summary>
    public class MessagesSetMemberRoleParams
    {
        /// <summary>
        /// Destination ID (group chat peer ID, 2000000000 + chat_id).
        /// </summary>
        [ApiParameter("peer_id")]
        public long PeerId { get; set; }

        /// <summary>
        /// ID of the member whose role is being modified.
        /// </summary>
        [ApiParameter("member_id")]
        public long MemberId { get; set; }

        /// <summary>
        /// Role to assign: "admin" or "member".
        /// </summary>
        [ApiParameter("role")]
        public string Role { get; set; }

        /// <summary>
        /// Community ID (if calling from a group).
        /// </summary>
        [ApiParameter("group_id")]
        public long? GroupId { get; set; }
    }
}
