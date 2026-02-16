using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Docs
{
    /// <summary>
    /// Parameters for the docs.save method.
    /// </summary>
    public class DocsSaveParams
    {
        /// <summary>
        /// A string representing the uploaded file.
        /// </summary>
        [JsonProperty("file")]
        public string File { get; set; } = null!;

        /// <summary>
        /// The document title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = null!;

        /// <summary>
        /// Tags for the document.
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; } = null!;

        /// <summary>
        /// Whether to return tags in the response.
        /// </summary>
        [JsonProperty("return_tags")]
        public int ReturnTags { get; set; } = 0;
    }
}
