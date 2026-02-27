using OpenVkNetApi.Utils;

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
        [ApiParameter("poll_id")]
        public int PollId { get; set; }

        /// <summary>
        /// The ID of the answer for which to return voters.
        /// </summary>
        [ApiParameter("answer_ids")]
        public int AnswerIds { get; set; }

        /// <summary>
        /// Offset needed to return a specific subset of voters.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of voters to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 6;
    }
}
