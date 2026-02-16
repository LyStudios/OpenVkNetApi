using Newtonsoft.Json;

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
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; } = null!;

        /// <summary>
        /// The text of the post.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// Copyright information for the post.
        /// </summary>
        [JsonProperty("copyright")]
        public string Copyright { get; set; } = "";

        /// <summary>
        /// 1 to post on behalf of a group.
        /// </summary>
        [JsonProperty("from_group")]
        public int FromGroup { get; set; } = 0;

        /// <summary>
        /// 1 to sign the post with the user's name.
        /// </summary>
        [JsonProperty("signed")]
        public int Signed { get; set; } = 0;

        /// <summary>
        /// Attachments to the post (e.g., "photo123_456,video789_012").
        /// </summary>
        [JsonProperty("attachments")]
        public string Attachments { get; set; } = "";

        /// <summary>
        /// The ID of the post being replied to.
        /// </summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; } = 0;

        /// <summary>
        /// Latitude for location.
        /// </summary>
        [JsonProperty("lat")]
        public float? Lat { get; set; } = null;

        /// <summary>
        /// Longitude for location.
        /// </summary>
        [JsonProperty("long")]
        public float? Long { get; set; } = null;

        /// <summary>
        /// The name of the place.
        /// </summary>
        [JsonProperty("place_name")]
        public string PlaceName { get; set; } = "";
    }
}
