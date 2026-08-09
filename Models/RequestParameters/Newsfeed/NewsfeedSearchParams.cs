using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Newsfeed
{
    /// <summary>
    /// Parameters for the newsfeed.search method.
    /// </summary>
    public class NewsfeedSearchParams
    {
        /// <summary>
        /// The search query.
        /// </summary>
        [ApiParameter("q")]
        public string Query { get; set; } = "";

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// The value from which to start returning posts for pagination.
        /// </summary>
        [ApiParameter("start_from")]
        public string StartFrom { get; set; } = "0";

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
        /// Number of posts to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 30;

        /// <summary>
        /// 1 to return extended information about users and groups.
        /// </summary>
        [ApiParameter("extended")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Extended { get; set; } = true;
    }
}
