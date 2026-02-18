using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Account;
using OpenVkNetApi.Models.Comments;

namespace OpenVkNetApi.Models.Wall
{
    /// <summary>
    /// Represents the response from a wall.getComment API call.
    /// </summary>
    public class WallGetComment
    {
        /// <summary>
        /// A list of comment items.
        /// </summary>
        [JsonProperty("items")]
        public List<WallComment>? Items { get; set; }

        /// <summary>
        /// Indicates if the current user can post comments.
        /// </summary>
        [JsonProperty("can_post")]
        public bool CanPost { get; set; }

        /// <summary>
        /// Indicates if a reply button should be shown.
        /// </summary>
        [JsonProperty("show_reply_button")]
        public bool ShowReplyButton { get; set; }

        /// <summary>
        /// Indicates if groups can post comments.
        /// </summary>
        [JsonProperty("groups_can_post")]
        public bool GroupsCanPost { get; set; }

        /// <summary>
        /// A list of user profiles related to the comments, if extended information was requested.
        /// </summary>
        [JsonProperty("profiles")]
        public List<ProfileInfo>? Profiles { get; set; }
    }
}
