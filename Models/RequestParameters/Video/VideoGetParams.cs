using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Models.RequestParameters.Video
{
    /// <summary>
    /// Parameters for the video.get method.
    /// </summary>
    public class VideoGetParams
    {
        /// <summary>
        /// ID of the user or community that owns the video.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; } = 0;

        /// <summary>
        /// A comma-separated list of video IDs in the format 'owner_id_video_id'.
        /// </summary>
        [JsonProperty("videos")]
        public string Videos { get; set; } = "";

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [JsonProperty("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of videos to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 30;

        /// <summary>
        /// 1 to return extended information about users and groups.
        /// </summary>
        [JsonProperty("extended")]
        public int Extended { get; set; } = 0;
    }
}
