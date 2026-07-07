using Newtonsoft.Json;

namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents comments metadata on a resource.
    /// </summary>
    public class CommentsInfo
    {
        /// <summary>
        /// The total number of comments.
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Indicates if the current user can post comments.
        /// </summary>
        [JsonProperty("can_post")]
        public bool? CanPost { get; set; }
    }
}
