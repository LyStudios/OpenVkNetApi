using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Board
{
    /// <summary>
    /// Parameters for the board.addTopic method.
    /// </summary>
    public class BoardAddTopicParams
    {
        /// <summary>
        /// ID of the community where the topic will be added.
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// The title of the topic.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = null!;

        /// <summary>
        /// The text content of the topic.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// True if the topic is created on behalf of the group.
        /// </summary>
        [JsonProperty("from_group")]
        public bool FromGroup { get; set; } = true;
    }
}
