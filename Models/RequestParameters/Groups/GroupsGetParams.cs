using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Groups
{
    /// <summary>
    /// Parameters for the groups.get method.
    /// </summary>
    public class GroupsGetParams
    {
        /// <summary>
        /// ID of the user whose groups to return.
        /// </summary>
        [ApiParameter("user_id")]
        public int UserId { get; set; } = 0;

        /// <summary>
        /// A list of additional fields to return for each group.
        /// </summary>
        [ApiParameter("fields")]
        public GroupFields Fields { get; set; } = GroupFields.None;

        /// <summary>
        /// Offset needed to return a specific subset of groups.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of groups to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 6;

        /// <summary>
        /// True to return only online members (0 or 1).
        /// </summary>
        [ApiParameter("online")]
        public bool Online { get; set; } = false;

        /// <summary>
        /// Filters the list of groups. Possible values: "groups", "admin".
        /// </summary>
        [ApiParameter("filter")]
        public string Filter { get; set; } = "groups";
    }
}
