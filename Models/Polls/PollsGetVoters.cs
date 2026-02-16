using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Polls
{
    /// <summary>
    /// Represents the response from the polls.getVoters method.
    /// </summary>
    public class PollsGetVoters
    {
        /// <summary>
        /// The ID of the answer for which voters are returned.
        /// </summary>
        [JsonProperty("answer_id")]
        public int AnswerId { get; set; }

        /// <summary>
        /// A list of users who voted for this answer.
        /// </summary>
        [JsonProperty("users")]
        public List<User>? Users { get; set; }
    }
}
