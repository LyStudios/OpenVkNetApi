using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Docs
{
    /// <summary>
    /// Represents a document type.
    /// </summary>
    public class DocType
    {
        /// <summary>
        /// The number of documents of this type.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// The type ID.
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        /// <summary>
        /// The name of the document type.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = null!;
    }
}
