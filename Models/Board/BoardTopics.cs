using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Board
{
    /// <summary>
    /// Represents a collection of board topics.
    /// </summary>
    public class BoardTopics : ExtendedCollection<BoardTopic>
    {
        /// <summary>
        /// Indicates if the current user can add new topics.
        /// </summary>
        [JsonProperty("can_add_topics")]
        public bool? CanAddTopics { get; set; }
    }
}
