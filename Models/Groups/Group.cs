using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Groups
{
    /// <summary>
    /// Represents a full group/community profile.
    /// </summary>
    public class Group : GroupBase
    {
        /// <summary>
        /// The type of the community (e.g., "group", "page", "event").
        /// </summary>
        [JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Indicates if the current user is a member of the group.
        /// </summary>
        [JsonProperty("is_member")]
        public int? IsMember { get; set; }

        /// <summary>
        /// Indicates if the group is verified.
        /// </summary>
        [JsonProperty("verified")]
        public int? Verified { get; set; }

        /// <summary>
        /// Indicates if the group has a profile photo.
        /// </summary>
        [JsonProperty("has_photo")]
        public int? HasPhoto { get; set; }

        /// <summary>
        /// The URL of the 50x50px profile photo.
        /// </summary>
        [JsonProperty("photo_50")]
        public string? Photo50 { get; set; }

        /// <summary>
        /// The URL of the 100x100px profile photo.
        /// </summary>
        [JsonProperty("photo_100")]
        public string? Photo100 { get; set; }

        /// <summary>
        /// The URL of the 200x200px profile photo.
        /// </summary>
        [JsonProperty("photo_200")]
        public string? Photo200 { get; set; }
        
        /// <summary>
        /// The number of members in the group.
        /// </summary>
        [JsonProperty("members_count")]
        public int? MembersCount { get; set; }
        
        /// <summary>
        /// The group's website.
        /// </summary>
        [JsonProperty("site")]
        public string? Site { get; set; }

        /// <summary>
        /// The group's description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        /// <summary>
        /// A list of contact people for the group.
        /// </summary>
        [JsonProperty("contacts")]
        public List<Contact>? Contacts { get; set; }

        /// <summary>
        /// Indicates if the current user can post on the group's wall.
        /// </summary>
        [JsonProperty("can_post")]
        public bool? CanPost { get; set; }
    }
}
