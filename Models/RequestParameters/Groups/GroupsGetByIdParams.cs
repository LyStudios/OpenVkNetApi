using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Models.RequestParameters.Groups
{
    /// <summary>
    /// Parameters for the groups.getById method.
    /// </summary>
    public class GroupsGetByIdParams
    {
        /// <summary>
        /// A comma-separated list of group IDs.
        /// </summary>
        [JsonProperty("group_ids")]
        public string GroupIds { get; set; } = "";

        /// <summary>
        /// A single group ID.
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; } = "";

        /// <summary>
        /// A list of additional fields to return for each group.
        /// </summary>
        [JsonProperty("fields")]
        public GroupFields Fields { get; set; } = GroupFields.None;

        /// <summary>
        /// Offset needed to return a specific subset of groups.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of groups to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 500;
    }
}
