using Newtonsoft.Json;
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
        public Collection<User> Users { get; set; }
    }
}
