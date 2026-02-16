using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Likes
{
    /// <summary>
    /// Represents the response from a likes.add or likes.delete API call.
    /// </summary>
    public class LikesAdd
    {
        /// <summary>
        /// The new total number of likes.
        /// </summary>
        [JsonProperty("likes")]
        public int Likes { get; set; }
    }
}
