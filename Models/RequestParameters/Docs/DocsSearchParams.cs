using OpenVkNetApi.Utils;

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
        [ApiParameter("q")]
        public string Q { get; set; } = "";

        /// <summary>
        /// Whether to search only among own documents.
        /// </summary>
        [ApiParameter("search_own")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool SearchOwn { get; set; } = false;

        /// <summary>
        /// The order of results.
        /// </summary>
        [ApiParameter("order")]
        public int Order { get; set; } = -1;

        /// <summary>
        /// Number of documents to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 30;

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Whether to return tags in the response.
        /// </summary>
        [ApiParameter("return_tags")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool ReturnTags { get; set; } = false;

        /// <summary>
        /// Document type.
        /// </summary>
        [ApiParameter("type")]
        public int Type { get; set; } = 0;

        /// <summary>
        /// Tags to filter by.
        /// </summary>
        [ApiParameter("tags")]
        public string? Tags { get; set; } = null;
    }
}
