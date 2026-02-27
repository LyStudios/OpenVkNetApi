using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Wall
{
    /// <summary>
    /// Parameters for the wall.post method.
    /// </summary>
    public class WallPostParams
    {
        /// <summary>
        /// ID of the user or community wall to post to.
        /// </summary>
        [ApiParameter("owner_id")]
        public string OwnerId { get; set; } = null!;

        /// <summary>
        /// The text of the post.
        /// </summary>
        [ApiParameter("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// Copyright information for the post.
        /// </summary>
        [ApiParameter("copyright")]
        public string Copyright { get; set; } = "";

        /// <summary>
        /// 1 to post on behalf of a group.
        /// </summary>
        [ApiParameter("from_group")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool FromGroup { get; set; } = false;

        /// <summary>
        /// 1 to sign the post with the user's name.
        /// </summary>
        [ApiParameter("signed")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Signed { get; set; } = false;

        /// <summary>
        /// Attachments to the post (e.g., "photo123_456,video789_012").
        /// </summary>
        [ApiParameter("attachments")]
        public string Attachments { get; set; } = "";

        /// <summary>
        /// The ID of the post being replied to.
        /// </summary>
        [ApiParameter("post_id")]
        public int PostId { get; set; } = 0;

        /// <summary>
        /// Latitude for location.
        /// </summary>
        [ApiParameter("lat")]
        public float? Lat { get; set; } = null;

        /// <summary>
        /// Longitude for location.
        /// </summary>
        [ApiParameter("long")]
        public float? Long { get; set; } = null;

        /// <summary>
        /// The name of the place.
        /// </summary>
        [ApiParameter("place_name")]
        public string PlaceName { get; set; } = "";
    }
}
