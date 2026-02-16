using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Board
{
    /// <summary>
    /// Represents a topic on a community's board.
    /// </summary>
    public class BoardTopic
    {
        /// <summary>
        /// The topic ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The ID of the user who created the topic.
        /// </summary>
        [JsonProperty("created_by")]
        public int CreatedBy { get; set; }

        /// <summary>
        /// The topic title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The date when the topic was created, in Unix time.
        /// </summary>
        [JsonProperty("created")]
        public long Created { get; set; }

        /// <summary>
        /// The date when the topic was last updated, in Unix time.
        /// </summary>
        [JsonProperty("updated")]
        public long Updated { get; set; }

        /// <summary>
        /// The ID of the user who last updated the topic.
        /// </summary>
        [JsonProperty("updated_by")]
        public long UpdatedBy { get; set; }

        /// <summary>
        /// The total number of comments in the topic.
        /// </summary>
        [JsonProperty("comments")]
        public int Comments { get; set; }

        /// <summary>
        /// Indicates if the topic is closed.
        /// </summary>
        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Indicates if the topic is pinned to the top.
        /// </summary>
        [JsonProperty("is_fixed")]
        public bool IsFixed { get; set; }
    }
}
