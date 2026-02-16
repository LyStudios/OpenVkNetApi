using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Board
{
    /// <summary>
    /// Parameters for the board.getTopics method.
    /// </summary>
    public class BoardGetTopicsParams
    {
        /// <summary>
        /// ID of the community.
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// A comma-separated list of topic IDs.
        /// </summary>
        [JsonProperty("topic_ids")]
        public string TopicIds { get; set; } = "";

        /// <summary>
        /// Offset needed to return a specific subset of topics.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of topics to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// True to return extended information.
        /// </summary>
        [JsonProperty("extended")]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// Whether to return a preview of the topic text.
        /// </summary>
        [JsonProperty("preview")]
        public int Preview { get; set; } = 0;

        /// <summary>
        /// The maximum length of the preview text.
        /// </summary>
        [JsonProperty("preview_length")]
        public int PreviewLength { get; set; } = 90;
    }
}
