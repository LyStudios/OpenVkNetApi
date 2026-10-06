using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Video
{
    /// <summary>
    /// Represents the result of editing a video.
    /// </summary>
    public class VideoEditResult
    {
        /// <summary>
        /// Indicates success (1).
        /// </summary>
        [JsonProperty("success")]
        public int Success { get; set; }
    }
}
