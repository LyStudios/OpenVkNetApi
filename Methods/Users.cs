using OpenVkNetApi.Utils;
using System.Threading.Tasks;
using System.Collections.Generic;
using OpenVkNetApi.Models.RequestParameters.Users;
using System.Threading;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Users;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with users.
    /// Encapsulates the <c>users.*</c> methods of the OpenVK API.
    /// </summary>
    public class Users : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Users"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Users(OpenVkApi api) : base(api, "users") { }

        /// <summary>
        /// Returns detailed information on users.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="User"/> objects.</returns>
        public async Task<List<User>> GetAsync(UsersGetParams @params, CancellationToken ct = default)
        {
            return await GetAsync<List<User>>("get", @params, ct);
        }

        /// <summary>
        /// Returns a list of a user's followers.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{User}"/> of follower objects.</returns>
        public async Task<Collection<User>> GetFollowersAsync(UsersGetFollowersParams @params, CancellationToken ct = default)
        {
            return await GetAsync<Collection<User>>("getFollowers", @params, ct);
        }

        /// <summary>
        /// Searches for users.
        /// </summary>
        /// <param name="params">Search parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{User}"/> of found user objects.</returns>
        public async Task<Collection<User>> SearchAsync(UsersSearchParams @params, CancellationToken ct = default)
        {
            return await GetAsync<Collection<User>>("search", @params, ct);
        }

        /// <summary>
        /// Reports a user.
        /// </summary>
        /// <param name="userId">The ID of the user to report.</param>
        /// <param name="type">The type of complaint (e.g., "spam", "abuse").</param>
        /// <param name="comment">A comment describing the complaint.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> ReportAsync(int userId, string type = "spam", string comment = "", CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["user_id"] = userId.ToString(),
                ["type"] = type,
                ["comment"] = comment
            };
            return await PostAsync<int>("report", parameters, ct);
        }
    }
}
