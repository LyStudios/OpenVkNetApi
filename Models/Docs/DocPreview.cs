using Newtonsoft.Json;
using OpenVkNetApi.Models.Photos;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Docs
{
    /// <summary>
    /// Represents the preview data for a document.
    /// </summary>
    public class DocPreview
    {
        /// <summary>
        /// Photo preview data.
        /// </summary>
        [JsonProperty("photo")]
        public DocPreviewPhoto? Photo { get; set; }

        /// <summary>
        /// Video preview data.
        /// </summary>
        [JsonProperty("video")]
        public DocPreviewVideo? Video { get; set; }
    }

    /// <summary>
    /// Represents the photo data within a document preview.
    /// </summary>
    public class DocPreviewPhoto
    {
        /// <summary>
        /// A list of available photo sizes.
        /// </summary>
        [JsonProperty("sizes")]
        public List<PhotoSize>? Sizes { get; set; }
    }

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
