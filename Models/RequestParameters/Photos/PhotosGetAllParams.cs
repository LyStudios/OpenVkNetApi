using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Photos
{
    /// <summary>
    /// Parameters for the photos.getAll method.
    /// </summary>
    public class PhotosGetAllParams
    {
        /// <summary>
        /// ID of the user or community that owns the photos.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// True to return extended information about photos.
        /// </summary>
        [ApiParameter("extended")]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// Offset needed to return a specific subset of photos.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of photos to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 100;

        /// <summary>
        /// True to return photo sizes.
        /// </summary>
        [ApiParameter("photo_sizes")]
        public bool PhotoSizes { get; set; } = false;
    }
}
