using OpenVkNetApi.Utils;

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
        [ApiParameter("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// A comma-separated list of topic IDs.
        /// </summary>
        [ApiParameter("topic_ids")]
        public string TopicIds { get; set; } = "";

        /// <summary>
        /// Offset needed to return a specific subset of topics.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of topics to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// True to return extended information.
        /// </summary>
        [ApiParameter("extended")]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// Whether to return a preview of the topic text.
        /// </summary>
        [ApiParameter("preview")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Preview { get; set; } = false;

        /// <summary>
        /// The maximum length of the preview text.
        /// </summary>
        [ApiParameter("preview_length")]
        public int PreviewLength { get; set; } = 90;
    }
}
