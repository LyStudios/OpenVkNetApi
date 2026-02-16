using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Groups
{
    /// <summary>
    /// Parameters for the groups.edit method.
    /// </summary>
    public class GroupsEditParams
    {
        /// <summary>
        /// The group ID.
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// The new group title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The new group description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The new group screen name (short address).
        /// </summary>
        [JsonProperty("screen_name")]
        public string? ScreenName { get; set; }

        /// <summary>
        /// The new group website.
        /// </summary>
        [JsonProperty("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Wall settings (0 - off, 1 - open, 2 - limited, 3 - closed). Default is -1 (no change).
        /// </summary>
        [JsonProperty("wall")]
        public int Wall { get; set; } = -1;

        /// <summary>
        /// Topics (board) settings. Default is null (no change).
        /// </summary>
        [JsonProperty("topics")]
        public int? Topics { get; set; }

        /// <summary>
        /// Admin list settings. Default is null (no change).
        /// </summary>
        [JsonProperty("adminlist")]
        public int? Adminlist { get; set; }

        /// <summary>
        /// Whether topics should be displayed above the wall. Default is null (no change).
        /// </summary>
        [JsonProperty("topicsAboveWall")]
        public int? TopicsAboveWall { get; set; }

        /// <summary>
        /// Whether to hide the group from the global feed. Default is null (no change).
        /// </summary>
        [JsonProperty("hideFromGlobalFeed")]
        public int? HideFromGlobalFeed { get; set; }

        /// <summary>
        /// Audio settings. Default is null (no change).
        /// </summary>
        [JsonProperty("audio")]
        public int? Audio { get; set; }
    }
}
