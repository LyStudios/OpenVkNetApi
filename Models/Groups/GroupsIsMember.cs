using Newtonsoft.Json;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.Groups
{
    /// <summary>
    /// Represents the extended response for the groups.isMember method.
    /// </summary>
    public class GroupsIsMember
    {
        /// <summary>
        /// Indicates if the user is a member of the group.
        /// </summary>
        [JsonProperty("member")]
        [JsonConverter(typeof(BoolToIntConverter))]
        public bool Member { get; set; }

        /// <summary>
        /// Indicates if the user has a pending join request.
        /// </summary>
        [JsonProperty("request")]
        [JsonConverter(typeof(BoolToIntConverter))]
        public bool Request { get; set; }

        /// <summary>
        /// Indicates if the user has a pending invitation to the group.
        /// </summary>
        [JsonProperty("invitation")]
        [JsonConverter(typeof(BoolToIntConverter))]
        public bool Invitation { get; set; }

        /// <summary>
        /// Indicates if the current user can invite others to the group.
        /// </summary>
        [JsonProperty("can_invite")]
        [JsonConverter(typeof(BoolToIntConverter))]
        public bool CanInvite { get; set; }

        /// <summary>
        /// Indicates if the current user can recall an invitation.
        /// </summary>
        [JsonProperty("can_recall")]
        [JsonConverter(typeof(BoolToIntConverter))]
        public bool CanRecall { get; set; }
    }
}
