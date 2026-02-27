using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Wall
{
    /// <summary>
    /// Parameters for the wall.get method.
    /// </summary>
    public class WallGetParams
    {
        /// <summary>
        /// ID of the user or community that owns the wall.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Domain of the user or community.
        /// </summary>
        [ApiParameter("domain")]
        public string Domain { get; set; } = "";

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
        /// Filters the returned posts ("all", "owner", "others", "postponed", "suggests").
        /// </summary>
        [ApiParameter("filter")]
        public string Filter { get; set; } = "all";

        /// <summary>
        /// 1 to return posts in RSS format.
        /// </summary>
        [ApiParameter("rss")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Rss { get; set; } = false;
    }
}
