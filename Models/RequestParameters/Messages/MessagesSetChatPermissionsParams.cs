using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the <c>messages.setChatPermissions</c> method.
    /// </summary>
    public class MessagesSetChatPermissionsParams
    {
        /// <summary>
        /// Destination ID (group chat peer ID, 2000000000 + chat_id).
        /// </summary>
        [ApiParameter("peer_id")]
        public long PeerId { get; set; }

        /// <summary>
        /// Chat ID (if peer_id is not passed).
        /// </summary>
        [ApiParameter("chat_id")]
        public long? ChatId { get; set; }

        /// <summary>
        /// Raw JSON permissions string or policy.
        /// </summary>
        [ApiParameter("permissions")]
        public string Permissions { get; set; }

        /// <summary>
        /// Who can invite: "all" or "admin".
        /// </summary>
        [ApiParameter("invite")]
        public string Invite { get; set; }

        /// <summary>
        /// Who can change chat info: "all" or "admin".
        /// </summary>
        [ApiParameter("change_info")]
        public string ChangeInfo { get; set; }

        /// <summary>
        /// Who can pin messages: "all" or "admin".
        /// </summary>
        [ApiParameter("change_pin")]
        public string ChangePin { get; set; }

        /// <summary>
        /// Who can use mass mentions (@all/@online): "all" or "admin".
        /// </summary>
        [ApiParameter("use_mass_mentions")]
        public string UseMassMentions { get; set; }

        /// <summary>
        /// Who can view invite link: "all" or "admin".
        /// </summary>
        [ApiParameter("see_invite_link")]
        public string SeeInviteLink { get; set; }

        /// <summary>
        /// Who can change invite link: "all" or "admin".
        /// </summary>
        [ApiParameter("change_invite_link")]
        public string ChangeInviteLink { get; set; }

        /// <summary>
        /// Who can start group calls: "all" or "admin".
        /// </summary>
        [ApiParameter("call")]
        public string Call { get; set; }

        /// <summary>
        /// Who can manage administrators: "all" or "admin".
        /// </summary>
        [ApiParameter("change_admins")]
        public string ChangeAdmins { get; set; }

        /// <summary>
        /// Community ID (if calling from a group).
        /// </summary>
        [ApiParameter("group_id")]
        public long? GroupId { get; set; }
    }
}
