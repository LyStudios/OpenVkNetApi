using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents the server address for uploading a photo to a wall.
    /// </summary>
    public class PhotosUploadServer
    {
        /// <summary>
        /// The URL to upload the photo to.
        /// </summary>
        [JsonProperty("upload_url")]
        public string? UploadUrl { get; set; }

        /// <summary>
        /// The ID of the album where the photo will be saved. Can be null.
        /// </summary>
        [JsonProperty("album_id")]
        public int? AlbumId { get; set; }

        /// <summary>
        /// The ID of the user who is performing the upload.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}
