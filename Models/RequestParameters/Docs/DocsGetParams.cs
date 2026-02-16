using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Docs
{
    /// <summary>
    /// Parameters for the docs.get method.
    /// </summary>
    public class DocsGetParams
    {
        /// <summary>
        /// Number of documents to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 30;

        /// <summary>
        /// Offset needed to return a specific subset of documents.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Document type.
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; } = -1;

        /// <summary>
        /// Owner ID of the documents.
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; } = null;

        /// <summary>
        /// Whether to return tags (0 or 1).
        /// </summary>
        [JsonProperty("return_tags")]
        public int ReturnTags { get; set; } = 0;

        /// <summary>
        /// The order of documents (0 - by date, 1 - by size, 2 - by title).
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; } = 0;
    }
}
