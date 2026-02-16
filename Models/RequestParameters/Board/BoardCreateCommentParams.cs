using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Board
{
    /// <summary>
    /// Parameters for the board.createComment method.
    /// </summary>
    public class BoardCreateCommentParams
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
        /// The text of the comment.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// True if the comment is published on behalf of the group.
        /// </summary>
        [JsonProperty("from_group")]
        public bool FromGroup { get; set; } = true;
    }
}
