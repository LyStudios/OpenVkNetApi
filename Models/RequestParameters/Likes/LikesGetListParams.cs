using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Likes
{
    /// <summary>
    /// Parameters for the likes.getList method.
    /// </summary>
    public class LikesGetListParams
    {
        /// <summary>
        /// The type of object for which to return likes (e.g., "post", "comment", "photo").
        /// </summary>
        [ApiParameter("type")]
        public string Type { get; set; } = null!;

        /// <summary>
        /// The ID of the owner of the object.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// The ID of the object.
        /// </summary>
        [ApiParameter("item_id")]
        public int ItemId { get; set; }

        /// <summary>
        /// Internal property to control extended information.
        /// </summary>
        [ApiParameter("extended")]
        internal bool Extended { get; set; } = false;

        /// <summary>
        /// Offset needed to return a specific subset of likes.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of likes to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// True to skip likes from the current user.
        /// </summary>
        [ApiParameter("skip_own")]
        public bool SkipOwn { get; set; } = false;
    }
}
