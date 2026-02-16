using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Groups
{
    /// <summary>
    /// Represents the extended response for the groups.isMember method.
    /// </summary>
    public class GroupsIsMember
    {
        /// <summary>
        /// Indicates if the user is a member of the group (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("member")]
        public int Member { get; set; }

        /// <summary>
        /// Indicates if the user has a pending join request (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("request")]
        public int Request { get; set; }

        /// <summary>
        /// Indicates if the user has a pending invitation to the group (1 for yes, 0 for no).
        /// </summary>
        [JsonProperty("invitation")]
        public int Invitation { get; set; }

        /// <summary>
        /// Indicates if the current user can invite others to the group.
        /// </summary>
        [JsonProperty("can_invite")]
        public int CanInvite { get; set; }

        /// <summary>
        /// Indicates if the current user can recall an invitation.
        /// </summary>
        [JsonProperty("can_recall")]
        public int CanRecall { get; set; }
    }
}
