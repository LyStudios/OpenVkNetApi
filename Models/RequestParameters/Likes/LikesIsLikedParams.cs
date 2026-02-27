using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Likes
{
    /// <summary>
    /// Parameters for the likes.isLiked method.
    /// </summary>
    public class LikesIsLikedParams
    {
        /// <summary>
        /// The ID of the user to check the like status for.
        /// </summary>
        [ApiParameter("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// The type of object to check (e.g., "post", "comment", "photo").
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
    }
}
