using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Video
{
    /// <summary>
    /// Represents the files structure containing links to video streams of different qualities.
    /// </summary>
    [JsonConverter(typeof(VideoFilesConverter))]
    public class VideoFiles
    {
        /// <summary>
        /// Gets or sets the URL of the 480p MP4 video stream.
        /// </summary>
        [JsonProperty("mp4_480")]
        public string Mp4480 { get; set; }
    }
}
