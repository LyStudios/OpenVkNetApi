using OpenVkNetApi.Utils;

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
        [ApiParameter("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// The new group title.
        /// </summary>
        [ApiParameter("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// The new group description.
        /// </summary>
        [ApiParameter("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// The new group screen name (short address).
        /// </summary>
        [ApiParameter("screen_name")]
        public string? ScreenName { get; set; } = null;

        /// <summary>
        /// The new group website.
        /// </summary>
        [ApiParameter("website")]
        public string? Website { get; set; } = null;

        /// <summary>
        /// Wall settings (0 - off, 1 - open, 2 - limited, 3 - closed). Default is -1 (no change).
        /// </summary>
        [ApiParameter("wall")]
        public int Wall { get; set; } = -1;

        /// <summary>
        /// Topics (board) settings. True = everyone can create topics, false = no change, null = no change.
        /// </summary>
        [ApiParameter("topics")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool? Topics { get; set; } = null;

        /// <summary>
        /// Admin list settings. True = show, false = hide, null = no change.
        /// </summary>
        [ApiParameter("adminlist")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool? Adminlist { get; set; } = null;

        /// <summary>
        /// Whether topics should be displayed above the wall. True = display, false = hide, null = no change.
        /// </summary>
        [ApiParameter("topicsAboveWall")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool? TopicsAboveWall { get; set; } = null;

        /// <summary>
        /// Whether to hide the group from the global feed. True = hide, false = show, null = no change.
        /// </summary>
        [ApiParameter("hideFromGlobalFeed")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool? HideFromGlobalFeed { get; set; } = null;

        /// <summary>
        /// Audio settings. True = everyone can upload, false = no change, null = no change.
        /// </summary>
        [ApiParameter("audio")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool? Audio { get; set; } = null;
    }
}
