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
            var parameters = new Dictionary<string, string>
            {
                ["poll_id"] = pollId.ToString(),
                ["extended"] = extended ? "1" : "0",
                ["fields"] = EnumHelper.GetEnumFlagsDescription(fields)
            };
            return await GetAsync<PollsGetById>("getById", parameters, ct);
        }

        /// <summary>
        /// Adds the current user's vote to a poll.
        /// </summary>
        /// <param name="pollId">The poll ID.</param>
        /// <param name="answersIds">A comma-separated list of answer IDs.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> AddVoteAsync(int pollId, string answersIds, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["poll_id"] = pollId.ToString(),
                ["answers_ids"] = answersIds
            };
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
            var parameters = new Dictionary<string, string>
            {
                ["poll_id"] = pollId.ToString()
            };
            return await PostAsync<int>("deleteVote", parameters, ct);
        }

        /// <summary>
        /// Returns a list of users who voted in a poll.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="PollsGetVoters"/> object containing a list of voters.</returns>
        public async Task<PollsGetVoters> GetVotersAsync(PollsGetVotersParams @params, CancellationToken ct = default)
        {
            return await GetAsync<PollsGetVoters>("getVoters", @params, ct);
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
