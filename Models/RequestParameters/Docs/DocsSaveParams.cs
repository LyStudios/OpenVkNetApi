using OpenVkNetApi.Utils;

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
        [ApiParameter("file")]
        public string File { get; set; } = null!;

        /// <summary>
        /// The document title.
        /// </summary>
        [ApiParameter("title")]
        public string Title { get; set; } = null!;

        /// <summary>
        /// Tags for the document.
        /// </summary>
        [ApiParameter("tags")]
        public string Tags { get; set; } = null!;

        /// <summary>
        /// Whether to return tags in the response.
        /// </summary>
        [ApiParameter("return_tags")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool? ReturnTags { get; set; } = false;
    }
}
