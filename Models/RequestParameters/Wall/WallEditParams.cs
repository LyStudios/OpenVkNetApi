using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Wall
{
    /// <summary>
    /// Parameters for the wall.edit method.
    /// </summary>
    public class WallEditParams
    {
        /// <summary>
        /// ID of the post owner.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// ID of the post to edit.
        /// </summary>
        [ApiParameter("post_id")]
        public int PostId { get; set; }

        /// <summary>
        /// The new text of the post.
        /// </summary>
        [ApiParameter("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// New attachments to the post.
        /// </summary>
        [ApiParameter("attachments")]
        public string Attachments { get; set; } = "";

        /// <summary>
        /// Copyright information.
        /// </summary>
        [ApiParameter("copyright")]
        public string? Copyright { get; set; } = null;

        /// <summary>
        /// 1 to mark the post as explicit, -1 to remove explicit flag, 0 to leave unchanged.
        /// </summary>
        [ApiParameter("explicit")]
        public int Explicit { get; set; } = -1;

        /// <summary>
        /// 1 to publish the post on behalf of a group.
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
    }
}
