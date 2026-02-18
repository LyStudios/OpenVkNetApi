using Newtonsoft.Json;

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
}