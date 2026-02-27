using OpenVkNetApi.Utils;

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
        [ApiParameter("photo")]
        public string Photo { get; set; } = null!;

        /// <summary>
        /// The 'hash' parameter returned by the upload server.
        /// </summary>
        [ApiParameter("hash")]
        public string Hash { get; set; } = null!;

        /// <summary>
        /// ID of the group to save the photo to.
        /// </summary>
        [ApiParameter("group_id")]
        public int GroupId { get; set; } = 0;

        /// <summary>
        /// The caption for the photo.
        /// </summary>
        [ApiParameter("caption")]
        public string? Caption { get; set; } = null;
    }
}
