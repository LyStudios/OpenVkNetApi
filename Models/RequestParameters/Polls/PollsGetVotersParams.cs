using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Polls
{
    /// <summary>
    /// Parameters for the polls.getVoters method.
    /// </summary>
    public class PollsGetVotersParams
    {
        /// <summary>
        /// The poll ID.
        /// </summary>
        [JsonProperty("poll_id")]
        public int PollId { get; set; }

        /// <summary>
        /// The ID of the answer for which to return voters.
        /// </summary>
        [JsonProperty("answer_ids")]
        public int AnswerIds { get; set; }

        /// <summary>
        /// Offset needed to return a specific subset of voters.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of voters to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 6;
    }
}
