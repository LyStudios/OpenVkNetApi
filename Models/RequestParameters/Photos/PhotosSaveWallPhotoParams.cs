using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Photos
{
    /// <summary>
    /// Parameters for the photos.saveWallPhoto method.
    /// </summary>
    public class PhotosSaveWallPhotoParams
    {
        /// <summary>
        /// The 'photo' parameter returned by the upload server.
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// The 'hash' parameter returned by the upload server.
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// ID of the group to save the photo to.
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; } = 0;

        /// <summary>
        /// The caption for the photo.
        /// </summary>
        [JsonProperty("caption")]
        public string? Caption { get; set; }
    }
}
