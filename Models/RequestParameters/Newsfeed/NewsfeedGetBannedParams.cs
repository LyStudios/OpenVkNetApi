using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Models.RequestParameters.Newsfeed
{
    /// <summary>
    /// Parameters for the newsfeed.getBanned method.
    /// </summary>
    public class NewsfeedGetBannedParams
    {
        /// <summary>
        /// 1 to return extended information about users and groups.
        /// </summary>
        [JsonProperty("extended")]
        public int Extended { get; set; } = 0;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [JsonProperty("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// Case for the user's name ("nom", "gen", etc.).
        /// </summary>
        [JsonProperty("name_case")]
        public string NameCase { get; set; } = "nom";

        /// <summary>
        /// 1 to merge user and group lists.
        /// </summary>
        [JsonProperty("merge")]
        public int Merge { get; set; } = 0;
    }
}
