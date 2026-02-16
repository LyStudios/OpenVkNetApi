using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Models.RequestParameters.Newsfeed
{
    /// <summary>
    /// Parameters for the newsfeed.getByType method.
    /// </summary>
    public class NewsfeedGetByTypeParams
    {
        /// <summary>
        /// The type of newsfeed to return (e.g., "top", "fresh").
        /// </summary>
        [JsonProperty("feed_type")]
        public string FeedType { get; set; } = "top";

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [JsonProperty("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// The value from which to start returning posts for pagination.
        /// </summary>
        [JsonProperty("start_from")]
        public int StartFrom { get; set; } = 0;

        /// <summary>
        /// Unix timestamp to start returning posts from.
        /// </summary>
        [JsonProperty("start_time")]
        public int StartTime { get; set; } = 0;

        /// <summary>
        /// Unix timestamp to end returning posts from.
        /// </summary>
        [JsonProperty("end_time")]
        public int EndTime { get; set; } = 0;

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of posts to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 30;

        /// <summary>
        /// 1 to return extended information about users and groups.
        /// </summary>
        [JsonProperty("extended")]
        public int Extended { get; set; } = 0;

        /// <summary>
        /// 1 to return banned posts.
        /// </summary>
        [JsonProperty("return_banned")]
        public int ReturnBanned { get; set; } = 0;
    }
}
