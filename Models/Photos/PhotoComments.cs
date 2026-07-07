using Newtonsoft.Json;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents comments information for a photo.
    /// </summary>
    public class PhotoComments
    {
        /// <summary>
        /// The number of comments.
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Indicates if the current user can post comments.
        /// </summary>
        [JsonProperty("can_post")]
        [JsonConverter(typeof(BoolToIntConverter))]
        public bool? CanPost { get; set; }
    }
}
