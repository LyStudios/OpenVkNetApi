using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Docs
{
    /// <summary>
    /// Parameters for the docs.edit method.
    /// </summary>
    public class DocsEditParams
    {
        /// <summary>
        /// The document owner's ID.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// The document ID.
        /// </summary>
        [ApiParameter("doc_id")]
        public int DocId { get; set; }

        /// <summary>
        /// The new document title.
        /// </summary>
        [ApiParameter("title")]
        public string? Title { get; set; } = "";

        /// <summary>
        /// A comma-separated list of new tags for the document.
        /// </summary>
        [ApiParameter("tags")]
        public string? Tags { get; set; } = "";

        /// <summary>
        /// The ID of the folder to move the document to.
        /// </summary>
        [ApiParameter("folder_id")]
        public int? FolderId { get; set; } = 0;

        /// <summary>
        /// Whether to hide the owner's name.
        /// </summary>
        [ApiParameter("owner_hidden")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool? OwnerHidden { get; set; } = null;
    }
}
