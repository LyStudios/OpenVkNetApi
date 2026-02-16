using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models.Status;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with user statuses.
    /// Encapsulates the <c>status.*</c> methods of the OpenVK API.
    /// </summary>
    public class Status : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Status"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Status(OpenVkApi api) : base(api, "status") { }

        /// <summary>
        /// Gets a user's or community's status.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <param name="groupId">The community ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="UserStatus"/> object.</returns>
        public async Task<UserStatus> GetAsync(int userId, int groupId, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["user_id"] = userId.ToString(),
                ["group_id"] = groupId.ToString()
            };

            return await GetAsync<UserStatus>("get", parameters, ct);
        }
        
        /// <summary>
        /// Sets a new status for the current user or community.
        /// </summary>
        /// <param name="text">The status text.</param>
        /// <param name="groupId">The community ID (if setting a community status).</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> SetAsync(string text, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["text"] = text,
                ["group_id"] = groupId.ToString()
            };
            return await PostAsync<int>("set", parameters, ct);
        }
    }
}
