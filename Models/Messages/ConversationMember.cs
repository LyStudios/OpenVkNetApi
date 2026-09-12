using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents a member of a conversation in OpenVK.
    /// </summary>
    public class ConversationMember
    {
        /// <summary>
        /// Gets or sets the member's user ID.
        /// </summary>
        [JsonProperty("member_id")]
        public int MemberId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who invited this member.
        /// </summary>
        [JsonProperty("invited_by")]
        public int InvitedBy { get; set; }

        /// <summary>
        /// Gets or sets the Unix timestamp when the member joined the conversation.
        /// </summary>
        [JsonProperty("join_date")]
        public long JoinDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the member is an administrator or owner of the conversation.
        /// </summary>
        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the member is the owner/creator of the conversation.
        /// </summary>
        [JsonProperty("is_owner")]
        public bool IsOwner { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the member is an appointed moderator of the conversation.
        /// </summary>
        [JsonProperty("is_moderator")]
        public bool IsModerator { get; set; }
    }
}
