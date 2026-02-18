using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Docs
{
    /// <summary>
    /// Represents the video data within a document preview.
    /// </summary>
    public class DocPreviewVideo
    {
        /// <summary>
        /// The video source URL.
        /// </summary>
        [JsonProperty("src")]
        public string? Src { get; set; }

        /// <summary>
        /// The video width in pixels.
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// The video height in pixels.
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// The video file size in bytes.
        /// </summary>
        [JsonProperty("file_size")]
        public long FileSize { get; set; }
    }
}