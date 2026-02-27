using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Groups
{
    /// <summary>
    /// Parameters for the groups.search method.
    /// </summary>
    public class GroupsSearchParams
    {
        /// <summary>
        /// Search query.
        /// </summary>
        [ApiParameter("q")]
        public string Q { get; set; } = null!;

        /// <summary>
        /// Offset needed to return a specific subset of groups.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of groups to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 100;

        /// <summary>
        /// A list of additional fields to return for each group.
        /// </summary>
        [ApiParameter("fields")]
        public GroupFields Fields { get; set; } = GroupFields.None;
    }
}
