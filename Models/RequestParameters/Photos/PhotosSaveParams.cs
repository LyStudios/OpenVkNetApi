using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Photos
{
    /// <summary>
    /// Parameters for the photos.save method.
    /// </summary>
    public class PhotosSaveParams
    {
        /// <summary>
        /// A JSON string with a list of photos to be saved.
        /// </summary>
        [ApiParameter("photos_list")]
        public string PhotosList { get; set; } = null!;

        /// <summary>
        /// The hash required to save the photos.
        /// </summary>
        [ApiParameter("hash")]
        public string Hash { get; set; } = null!;

        /// <summary>
        /// ID of the album to save photos to.
        /// </summary>
        [ApiParameter("album_id")]
        public int? AlbumId { get; set; } = 0;

        /// <summary>
        /// The caption for the photos.
        /// </summary>
        [ApiParameter("caption")]
        public string? Caption { get; set; }
    }
}
