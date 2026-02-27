using OpenVkNetApi.Utils;

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
        [ApiParameter("count")]
        public int Count { get; set; } = 30;

        /// <summary>
        /// Offset needed to return a specific subset of documents.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Document type.
        /// </summary>
        [ApiParameter("type")]
        public int Type { get; set; } = -1;

        /// <summary>
        /// Owner ID of the documents.
        /// </summary>
        [ApiParameter("owner_id")]
        public int? OwnerId { get; set; } = null;

        /// <summary>
        /// Whether to return tags (0 or 1).
        /// </summary>
        [ApiParameter("return_tags")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool ReturnTags { get; set; } = false;

        /// <summary>
        /// The order of documents (0 - by date, 1 - by size, 2 - by title).
        /// </summary>
        [ApiParameter("order")]
        public int Order { get; set; } = 0;
    }
}
