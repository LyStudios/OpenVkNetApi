using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Photos
{
    /// <summary>
    /// Parameters for the photos.getAlbums method.
    /// </summary>
    public class PhotosGetAlbumsParams
    {
        /// <summary>
        /// ID of the user or community that owns the albums.
        /// </summary>
        [ApiParameter("owner_id")]
        public int? OwnerId { get; set; } = null;

        /// <summary>
        /// A comma-separated list of album IDs.
        /// </summary>
        [ApiParameter("album_ids")]
        public string AlbumIds { get; set; } = "";

        /// <summary>
        /// Offset needed to return a specific subset of albums.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of albums to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 100;

        /// <summary>
        /// True to return system albums.
        /// </summary>
        [ApiParameter("need_system")]
        public bool NeedSystem { get; set; } = true;

        /// <summary>
        /// True to return album covers.
        /// </summary>
        [ApiParameter("need_covers")]
        public bool NeedCovers { get; set; } = true;

        /// <summary>
        /// True to return photo sizes.
        /// </summary>
        [ApiParameter("photo_sizes")]
        public bool PhotoSizes { get; set; } = false;
    }
}
