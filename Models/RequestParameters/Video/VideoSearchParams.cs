using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Video
{
    /// <summary>
    /// Parameters for the video.search method.
    /// </summary>
    public class VideoSearchParams
    {
        /// <summary>
        /// Search query.
        /// </summary>
        [ApiParameter("q")]
        public string Q { get; set; } = "";

        /// <summary>
        /// Sort order of the search results.
        /// </summary>
        [ApiParameter("sort")]
        public int Sort { get; set; } = 0;

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of videos to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// 1 to return extended information about users and groups.
        /// </summary>
        [ApiParameter("extended")]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;
    }
}
