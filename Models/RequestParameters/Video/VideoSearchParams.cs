using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

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
        [JsonProperty("q")]
        public string Q { get; set; } = "";

        /// <summary>
        /// Sort order of the search results.
        /// </summary>
        [JsonProperty("sort")]
        public int Sort { get; set; } = 0;

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of videos to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// 1 to return extended information about users and groups.
        /// </summary>
        [JsonProperty("extended")]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [JsonProperty("fields")]
        public UserFields Fields { get; set; } = UserFields.None;
    }
}
