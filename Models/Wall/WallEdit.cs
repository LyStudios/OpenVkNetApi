using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Wall
{
    /// <summary>
    /// Represents the result of a wall.edit API call.
    /// </summary>
    public class WallEdit
    {
        /// <summary>
        /// The ID of the edited post.
        /// </summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}
