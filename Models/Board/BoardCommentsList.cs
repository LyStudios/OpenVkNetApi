using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Users;
using OpenVkNetApi.Models.Groups;

namespace OpenVkNetApi.Models.Board
{
    /// <summary>
    /// Represents a list of board comments, including associated user and group profiles.
    /// </summary>
    public class BoardCommentsList
    {
        /// <summary>
        /// The list of comment items.
        /// </summary>
        [JsonProperty("items")]
        public List<BoardComment>? Items { get; set; }

        /// <summary>
        /// A list of user profiles for the authors of the comments.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User>? Profiles { get; set; }

        /// <summary>
        /// A list of group profiles for the authors of the comments.
        /// </summary>
        [JsonProperty("groups")]
        public List<Group>? Groups { get; set; }
    }
}
