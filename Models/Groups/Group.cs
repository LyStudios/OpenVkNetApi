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
        public string Type { get; set; }

        /// <summary>
        /// Indicates if the current user is a member of the group.
        /// </summary>
        [JsonProperty("is_member")]
        public bool? IsMember { get; set; }

        /// <summary>
        /// Indicates if the group is verified.
        /// </summary>
        [JsonProperty("verified")]
        public bool? Verified { get; set; }

        /// <summary>
        /// Indicates if the group has a profile photo.
        /// </summary>
        [JsonProperty("has_photo")]
        public bool? HasPhoto { get; set; }

        /// <summary>
        /// The URL of the 50x50px profile photo.
        /// </summary>
        [JsonProperty("photo_50")]
        public string Photo50 { get; set; }

        /// <summary>
        /// The URL of the 100x100px profile photo.
        /// </summary>
        [JsonProperty("photo_100")]
        public string Photo100 { get; set; }

        /// <summary>
        /// The URL of the 200x200px profile photo.
        /// </summary>
        [JsonProperty("photo_200")]
        public string Photo200 { get; set; }

        /// <summary>
        /// The number of members in the group.
        /// </summary>
        [JsonProperty("members_count")]
        public int? MembersCount { get; set; }

        /// <summary>
        /// The group's website.
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        /// The group's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A list of contact people for the group.
        /// </summary>
        [JsonProperty("contacts")]
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// Indicates if the current user can post on the group's wall.
        /// </summary>
        [JsonProperty("can_post")]
        public bool? CanPost { get; set; }

        /// <summary>
        /// The real negative ID of the community.
        /// </summary>
        [JsonProperty("real_id")]
        public int? RealId { get; set; }

        /// <summary>
        /// The group's background picture URLs (OpenVK custom feature).
        /// </summary>
        [JsonProperty("background")]
        public List<string> Background { get; set; }

        /// <summary>
        /// Indicates if the user can suggest posts in the community.
        /// </summary>
        [JsonProperty("can_suggest")]
        public bool? CanSuggest { get; set; }

        /// <summary>
        /// Start date of the event in Unix time.
        /// </summary>
        [JsonProperty("start_date")]
        public long? StartDate { get; set; }

        /// <summary>
        /// Number of suggested posts in the community.
        /// </summary>
        [JsonProperty("suggested_count")]
        public int? SuggestedCount { get; set; }

        /// <summary>
        /// Owner/Creator user ID of the community.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// URL of the original 200px profile photo.
        /// </summary>
        [JsonProperty("photo_200_orig")]
        public string Photo200Orig { get; set; }

        /// <summary>
        /// URL of the original 400px profile photo.
        /// </summary>
        [JsonProperty("photo_400_orig")]
        public string Photo400Orig { get; set; }

        /// <summary>
        /// URL of the maximum size profile photo.
        /// </summary>
        [JsonProperty("photo_max")]
        public string PhotoMax { get; set; }
    }
}
