using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents the server address for uploading an owner's photo (profile or group avatar).
    /// </summary>
    public class PhotosOwnerPhotoUploadServer
    {
        /// <summary>
        /// The URL to upload the photo to.
        /// </summary>
        [JsonProperty("upload_url")]
        public string? UploadUrl { get; set; }
    }
}
