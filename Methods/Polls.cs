using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models.Polls;
using OpenVkNetApi.Models.RequestParameters.Polls;
using OpenVkNetApi.Utils;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with polls.
    /// Encapsulates the <c>polls.*</c> methods of the OpenVK API.
    /// </summary>
    public class Polls : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Polls"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Polls(OpenVkApi api) : base(api, "polls") { }

        /// <summary>
        /// Returns detailed information about a poll.
        /// </summary>
        /// <param name="pollId">The poll ID.</param>
        /// <param name="extended">True to return extended information.</param>
        /// <param name="fields">A list of additional profile fields to return.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="PollsGetById"/> object with poll data.</returns>
        public async Task<PollsGetById> GetByIdAsync(int pollId, bool extended = false, UserFields fields = UserFields.None, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("poll_id", pollId)
                .Add("extended", extended ? 1 : 0)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .ToDictionary();

            return await GetAsync<PollsGetById>("getById", parameters, ct);
        }

        /// <summary>
        /// Adds the current user's vote to a poll.
        /// </summary>
        /// <param name="pollId">The poll ID.</param>
        /// <param name="answerIds">A list of answer IDs to vote for.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> AddVoteAsync(int pollId, IEnumerable<int> answerIds, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("poll_id", pollId)
                .Add("answer_ids", string.Join(",", answerIds))
                .ToDictionary();

            return await PostAsync<int>("addVote", parameters, ct);
        }

        /// <summary>
        /// Deletes the current user's vote from a poll.
        /// </summary>
        /// <param name="pollId">The poll ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> DeleteVoteAsync(int pollId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("poll_id", pollId)
                .ToDictionary();

            return await PostAsync<int>("deleteVote", parameters, ct);
        }

        /// <summary>
        /// Returns a list of users who voted in a poll.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="PollsGetVoters"/> objects containing voters for each option.</returns>
        public async Task<List<PollsGetVoters>> GetVotersAsync(PollsGetVotersParams @params, CancellationToken ct = default)
        {
            return await GetAsync<List<PollsGetVoters>>("getVoters", @params, ct);
        }

        /// <summary>
        /// Creates a new poll.
        /// </summary>
        /// <param name="params">Parameters for the poll creation.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Poll"/> object representing the created poll.</returns>
        public async Task<Poll> CreateAsync(PollsCreateParams @params, CancellationToken ct = default)
        {
            return await PostAsync<Poll>("create", @params, ct);
        }
    }
}
