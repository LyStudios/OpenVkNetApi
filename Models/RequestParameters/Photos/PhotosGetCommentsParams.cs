using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Photos
{
    /// <summary>
    /// Parameters for the photos.getComments method.
    /// </summary>
    public class PhotosGetCommentsParams
    {
        /// <summary>
        /// ID of the user or community that owns the photo.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Photo ID.
        /// </summary>
        [ApiParameter("photo_id")]
        public int PhotoId { get; set; }

        /// <summary>
        /// True to return the 'likes' object.
        /// </summary>
        [ApiParameter("need_likes")]
        public bool NeedLikes { get; set; } = false;

        /// <summary>
        /// Offset needed to return a specific subset of comments.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of comments to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 100;

        /// <summary>
        /// True to return extended information about users who posted comments.
        /// </summary>
        [ApiParameter("extended")]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// A list of additional fields to return.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;
    }
}
