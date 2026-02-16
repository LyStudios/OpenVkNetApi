using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Groups
{
    /// <summary>
    /// Represents basic information about a group/community.
    /// </summary>
    public class GroupBase
    {
        /// <summary>
        /// The group ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The group name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The group's screen name (short address).
        /// </summary>
        [JsonProperty("screen_name")]
        public string ScreenName { get; set; } = null!;

        /// <summary>
        /// Indicates if the group is closed (private).
        /// </summary>
        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Indicates if the current user can access the closed group.
        /// </summary>
        [JsonProperty("can_access_closed")]
        public bool CanAccessClosed { get; set; }
    }
}
