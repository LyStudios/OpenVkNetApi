using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Likes
{
    /// <summary>
    /// Parameters for the likes.getList method.
    /// </summary>
    public class LikesGetListParams
    {
        /// <summary>
        /// The type of object for which to return likes (e.g., "post", "comment", "photo").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = null!;

        /// <summary>
        /// The ID of the owner of the object.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// The ID of the object.
        /// </summary>
        [JsonProperty("item_id")]
        public int ItemId { get; set; }

        /// <summary>
        /// Internal property to control extended information.
        /// </summary>
        [JsonProperty("extended")]
        internal bool Extended { get; set; } = false;

        /// <summary>
        /// Offset needed to return a specific subset of likes.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of likes to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// True to skip likes from the current user.
        /// </summary>
        [JsonProperty("skip_own")]
        public bool SkipOwn { get; set; } = false;
    }
}
