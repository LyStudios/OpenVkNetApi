using Newtonsoft.Json;

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
        [JsonProperty("object")]
        public string Object { get; set; } = null!;

        /// <summary>
        /// A message to include with the repost.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// Attachments to the repost.
        /// </summary>
        [JsonProperty("attachments")]
        public string Attachments { get; set; } = "";

        /// <summary>
        /// ID of the group to repost to.
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; } = 0;

        /// <summary>
        /// 1 to repost on behalf of a group.
        /// </summary>
        [JsonProperty("as_group")]
        public int AsGroup { get; set; } = 0;

        /// <summary>
        /// 1 to sign the repost with the user's name.
        /// </summary>
        [JsonProperty("signed")]
        public int Signed { get; set; } = 0;
    }
}
