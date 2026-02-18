using Newtonsoft.Json;
using OpenVkNetApi.Models.Photos;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Docs
{
    /// <summary>
    /// Represents the photo data within a document preview.
    /// </summary>
    public class DocPreviewPhoto
    {
        /// <summary>
        /// A list of available photo sizes.
        /// </summary>
        [JsonProperty("sizes")]
        public List<PhotoSize>? Sizes { get; set; }
    }
}
