using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Wall
{
    /// <summary>
    /// Parameters for the wall.get method.
    /// </summary>
    public class WallGetParams
    {
        /// <summary>
        /// ID of the user or community that owns the wall.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Domain of the user or community.
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; } = "";

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of posts to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 30;

        /// <summary>
        /// 1 to return extended information about users and groups.
        /// </summary>
        [JsonProperty("extended")]
        public int Extended { get; set; } = 0;

        /// <summary>
        /// Filters the returned posts ("all", "owner", "others", "postponed", "suggests").
        /// </summary>
        [JsonProperty("filter")]
        public string Filter { get; set; } = "all";

        /// <summary>
        /// 1 to return posts in RSS format.
        /// </summary>
        [JsonProperty("rss")]
        public int Rss { get; set; } = 0;
    }
}
