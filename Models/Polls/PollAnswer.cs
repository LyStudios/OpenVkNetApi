using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Polls
{
    /// <summary>
    /// Represents an answer option for a poll.
    /// </summary>
    public class PollAnswer
    {
        /// <summary>
        /// The answer ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The percentage rate of votes for this answer.
        /// </summary>
        [JsonProperty("rate")]
        public float Rate { get; set; }

        /// <summary>
        /// The answer text.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The number of votes for this answer.
        /// </summary>
        [JsonProperty("votes")]
        public int Votes { get; set; }
    }
}
