using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents the result of uploading a chat photo to the upload server.
    /// </summary>
    public class ChatPhotoUploadResult
    {
        /// <summary>
        /// The uploaded file identifier.
        /// </summary>
        [JsonProperty("file")]
        public string File { get; set; }

        /// <summary>
        /// The security hash required to save the photo.
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}
