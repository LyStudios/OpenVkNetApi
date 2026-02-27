using Newtonsoft.Json;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Wall
{
    /// <summary>
    /// Parameters for the wall.repost method.
    /// </summary>
    public class WallRepostParams
    {
        /// <summary>
        /// The object to repost in the format 'owner_id_item_id'.
        /// </summary>
        [ApiParameter("object")]
        public string Object { get; set; } = null!;

        /// <summary>
        /// A message to include with the repost.
        /// </summary>
        [ApiParameter("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// Attachments to the repost.
        /// </summary>
        [ApiParameter("attachments")]
        public string Attachments { get; set; } = "";

        /// <summary>
        /// ID of the group to repost to.
        /// </summary>
        [ApiParameter("group_id")]
        public int GroupId { get; set; } = 0;

        /// <summary>
        /// 1 to repost on behalf of a group.
        /// </summary>
        [ApiParameter("as_group")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool AsGroup { get; set; } = false;

        /// <summary>
        /// 1 to sign the repost with the user's name.
        /// </summary>
        [ApiParameter("signed")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Signed { get; set; } = false;
    }
}
