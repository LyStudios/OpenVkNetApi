using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Photos
{
    /// <summary>
    /// Parameters for the photos.editAlbum method.
    /// </summary>
    public class PhotosEditAlbumParams
    {
        /// <summary>
        /// Album ID.
        /// </summary>
        [ApiParameter("album_id")]
        public int AlbumId { get; set; }

        /// <summary>
        /// Album owner's ID.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// New album title.
        /// </summary>
        [ApiParameter("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// New album description.
        /// </summary>
        [ApiParameter("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// Privacy settings for the album.
        /// </summary>
        [ApiParameter("privacy")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Privacy { get; set; } = false;
    }
}
