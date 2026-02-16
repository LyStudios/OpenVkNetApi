using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Friends;
using OpenVkNetApi.Models.RequestParameters.Friends;
using OpenVkNetApi.Models.Users;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with friends.
    /// Encapsulates the <c>friends.*</c> methods of the OpenVK API.
    /// </summary>
    public class Friends : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Friends"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Friends(OpenVkApi api) : base(api, "friends") { }

        /// <summary>
        /// Returns a list of the user's friends.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{User}"/> of friend objects.</returns>
        public async Task<Collection<User>> GetAsync(FriendsGetParams @params, CancellationToken cancellationToken = default)
        {
            return await GetAsync<Collection<User>>("get", @params, cancellationToken);
        }
        
        /// <summary>
        /// Adds a user to the current user's friends list or sends a friend request.
        /// </summary>
        /// <param name="userId">The ID of the user to add.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's response code.</returns>
        public async Task<int> AddAsync(string userId, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["user_id"] = userId
            };
            return await PostAsync<int>("add", parameters, cancellationToken);
        }

        /// <summary>
        /// Removes a user from the current user's friends list or declines a friend request.
        /// </summary>
        /// <param name="userId">The ID of the user to remove.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's response code.</returns>
        public async Task<int> DeleteAsync(string userId, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["user_id"] = userId
            };
            return await PostAsync<int>("delete", parameters, cancellationToken);
        }

        /// <summary>
        /// Checks the friend status between users.
        /// </summary>
        /// <param name="userIds">A comma-separated list of user IDs.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="FriendStatus"/> objects indicating the relationship status.</returns>
        public async Task<List<FriendStatus>> AreFriendsAsync(string userIds, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["user_ids"] = userIds
            };
            return await GetAsync<List<FriendStatus>>("areFriends", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns a list of incoming or outgoing friend requests.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{User}"/> of users who have sent or received a friend request.</returns>
        public async Task<Collection<User>> GetRequestsAsync(FriendsGetRequestsParams @params, CancellationToken cancellationToken = default)
        {
            return await GetAsync<Collection<User>>("getRequests", @params, cancellationToken);
        }
    }
}
