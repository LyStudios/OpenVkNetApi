using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Docs
{
    /// <summary>
    /// Represents a document.
    /// </summary>
    public class Doc
    {
        /// <summary>
        /// The document ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The document owner's ID.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// The document title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The file size in bytes.
        /// </summary>
        [JsonProperty("size")]
        public long Size { get; set; }

        /// <summary>
        /// The file extension.
        /// </summary>
        [JsonProperty("ext")]
        public string? Extension { get; set; }

        /// <summary>
        /// The URL of the document.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The date when the document was uploaded, in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// The document type.
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// Indicates if the document is hidden.
        /// </summary>
        [JsonProperty("is_hidden")]
        public int IsHidden { get; set; }

        /// <summary>
        /// Indicates if the document is licensed.
        /// </summary>
        [JsonProperty("is_licensed")]
        public int IsLicensed { get; set; }

        /// <summary>
        /// Indicates if the document is marked as unsafe.
        /// </summary>
        [JsonProperty("is_unsafe")]
        public int IsUnsafe { get; set; }

        /// <summary>
        /// The folder ID.
        /// </summary>
        [JsonProperty("folder_id")]
        public int FolderId { get; set; }

        /// <summary>
        /// The access key for the document.
        /// </summary>
        [JsonProperty("access_key")]
        public string? AccessKey { get; set; }
        
        /// <summary>
        /// The preview data for the document.
        /// </summary>
        [JsonProperty("preview")]
        public DocPreview? Preview { get; set; }

        /// <summary>
        /// A list of tags for the document.
        /// </summary>
        [JsonProperty("tags")]
        public List<string>? Tags { get; set; }
    }
}
