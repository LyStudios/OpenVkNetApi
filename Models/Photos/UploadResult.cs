using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents the result from the intermediate photo upload server. This model is intended for internal use.
    /// </summary>
    internal class UploadResult
    {
        /// <summary>
        /// A string representation of the uploaded photo, used for single-file uploads.
        /// </summary>
        [JsonProperty("photo")]
        public string? Photo { get; set; }

        /// <summary>
        /// A JSON string representing a list of uploaded photos, used for multi-file uploads.
        /// </summary>
        [JsonProperty("photos_list")]
        public string? PhotosList { get; set; }

        /// <summary>
        /// A hash string required to save the uploaded photo(s).
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; } = null!;
    }
}
