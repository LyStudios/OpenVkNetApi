using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Board
{
    /// <summary>
    /// Parameters for the board.getComments method.
    /// </summary>
    public class BoardGetCommentsParams
    {
        /// <summary>
        /// ID of the community.
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// ID of the topic.
        /// </summary>
        [JsonProperty("topic_id")]
        public int TopicId { get; set; }

        /// <summary>
        /// True to return the 'likes' object.
        /// </summary>
        [JsonProperty("need_likes")]
        public bool NeedLikes { get; set; } = false;

        /// <summary>
        /// Offset needed to return a specific subset of comments.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of comments to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// True to return extended information about users who posted comments.
        /// </summary>
        [JsonProperty("extended")]
        public bool Extended { get; set; } = false;
    }
}
