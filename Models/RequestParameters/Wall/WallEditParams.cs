using Newtonsoft.Json;

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
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// ID of the post to edit.
        /// </summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        /// <summary>
        /// The new text of the post.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// New attachments to the post.
        /// </summary>
        [JsonProperty("attachments")]
        public string Attachments { get; set; } = "";

        /// <summary>
        /// Copyright information.
        /// </summary>
        [JsonProperty("copyright")]
        public string? Copyright { get; set; }

        /// <summary>
        /// 1 to mark the post as explicit, -1 to remove explicit flag, 0 to leave unchanged.
        /// </summary>
        [JsonProperty("explicit")]
        public int Explicit { get; set; } = -1;

        /// <summary>
        /// 1 to publish the post on behalf of a group.
        /// </summary>
        [JsonProperty("from_group")]
        public int FromGroup { get; set; } = 0;

        /// <summary>
        /// 1 to sign the post with the user's name.
        /// </summary>
        [JsonProperty("signed")]
        public int Signed { get; set; } = 0;
    }
}
