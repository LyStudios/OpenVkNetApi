using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Docs
{
    /// <summary>
    /// Parameters for the docs.search method.
    /// </summary>
    public class DocsSearchParams
    {
        /// <summary>
        /// Search query.
        /// </summary>
        [JsonProperty("q")]
        public string Q { get; set; } = "";

        /// <summary>
        /// Whether to search only among own documents.
        /// </summary>
        [JsonProperty("search_own")]
        public int SearchOwn { get; set; } = -1;

        /// <summary>
        /// The order of results.
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; } = -1;

        /// <summary>
        /// Number of documents to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 30;

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Whether to return tags in the response.
        /// </summary>
        [JsonProperty("return_tags")]
        public int ReturnTags { get; set; } = 0;

        /// <summary>
        /// Document type.
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; } = 0;

        /// <summary>
        /// Tags to filter by.
        /// </summary>
        [JsonProperty("tags")]
        public string? Tags { get; set; }
    }
}
