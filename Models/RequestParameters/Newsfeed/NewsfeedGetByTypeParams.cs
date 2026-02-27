using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

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
        [ApiParameter("feed_type")]
        public string FeedType { get; set; } = "top";

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// The value from which to start returning posts for pagination.
        /// </summary>
        [ApiParameter("start_from")]
        public int StartFrom { get; set; } = 0;

        /// <summary>
        /// Unix timestamp to start returning posts from.
        /// </summary>
        [ApiParameter("start_time")]
        public int StartTime { get; set; } = 0;

        /// <summary>
        /// Unix timestamp to end returning posts from.
        /// </summary>
        [ApiParameter("end_time")]
        public int EndTime { get; set; } = 0;

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of posts to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 30;

        /// <summary>
        /// 1 to return extended information about users and groups.
        /// </summary>
        [ApiParameter("extended")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// 1 to return banned posts.
        /// </summary>
        [ApiParameter("return_banned")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool ReturnBanned { get; set; } = false;
    }
}
