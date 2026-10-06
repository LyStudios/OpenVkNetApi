using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Enums;
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
            var parameters = new RequestParams()
                .Add("user_id", userId)
                .ToDictionary();

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
            var parameters = new RequestParams()
                .Add("user_id", userId)
                .ToDictionary();

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
            var parameters = new RequestParams()
                .Add("user_ids", userIds)
                .ToDictionary();

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

        /// <summary>
        /// Returns custom friend lists.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{FriendList}"/> of friend lists.</returns>
        public async Task<Collection<FriendList>> GetListsAsync(CancellationToken cancellationToken = default)
        {
            return await GetAsync<Collection<FriendList>>("getLists", null, cancellationToken);
        }

        /// <summary>
        /// Deletes a custom friend list.
        /// </summary>
        /// <param name="listId">The list ID to delete.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code.</returns>
        public async Task<int> DeleteListAsync(int listId, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("list_id", listId)
                .ToDictionary();

            return await PostAsync<int>("deleteList", parameters, cancellationToken);
        }

        /// <summary>
        /// Edits friend lists for a specific friend.
        /// </summary>
        /// <param name="userId">The ID of the friend.</param>
        /// <param name="listIds">A comma-separated list of list IDs.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code.</returns>
        public async Task<int> EditAsync(long userId, string listIds = "", CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("user_id", userId)
                .Add("list_ids", listIds)
                .ToDictionary();

            return await PostAsync<int>("edit", parameters, cancellationToken);
        }

        /// <summary>
        /// Edits a custom friend list.
        /// </summary>
        /// <param name="listId">The ID of the list to edit.</param>
        /// <param name="name">The new name of the list.</param>
        /// <param name="userIds">A comma-separated list of user IDs for the list.</param>
        /// <param name="addUserIds">A comma-separated list of user IDs to add.</param>
        /// <param name="deleteUserIds">A comma-separated list of user IDs to delete.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code.</returns>
        public async Task<int> EditListAsync(
            int listId,
            string name = "",
            string userIds = "",
            string addUserIds = "",
            string deleteUserIds = "",
            CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("list_id", listId)
                .Add("name", name)
                .Add("user_ids", userIds)
                .Add("add_user_ids", addUserIds)
                .Add("delete_user_ids", deleteUserIds)
                .ToDictionary();

            return await PostAsync<int>("editList", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns a list of user IDs of a user's friends who are currently online.
        /// </summary>
        /// <param name="userId">Target user ID.</param>
        /// <param name="onlineMobile">Whether to return mobile online friends.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A list of friend user IDs who are online.</returns>
        public async Task<List<int>> GetOnlineAsync(int userId = 0, bool onlineMobile = false, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("user_id", userId)
                .Add("online_mobile", onlineMobile ? 1 : 0)
                .ToDictionary();

            return await GetAsync<List<int>>("getOnline", parameters, cancellationToken);
        }

        /// <summary>
        /// Searches for friends matching the specified query.
        /// </summary>
        /// <param name="query">Search query string.</param>
        /// <param name="userId">User ID whose friends to search.</param>
        /// <param name="fields">Profile fields to return.</param>
        /// <param name="offset">Offset for pagination.</param>
        /// <param name="count">Number of friends to return.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{User}"/> of friends found.</returns>
        public async Task<Collection<User>> SearchAsync(string query, int userId = 0, UserFields fields = UserFields.None, int offset = 0, int count = 100, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("q", query)
                .Add("user_id", userId)
                .Add("fields", fields)
                .Add("offset", offset)
                .Add("count", count)
                .ToDictionary();

            return await GetAsync<Collection<User>>("search", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns a list of suggested friends.
        /// </summary>
        /// <param name="filter">Suggestion filter type (e.g. "mutual").</param>
        /// <param name="fields">Profile fields to return.</param>
        /// <param name="offset">Offset for pagination.</param>
        /// <param name="count">Number of friends to return.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{User}"/> of suggested friends.</returns>
        public async Task<Collection<User>> GetSuggestionsAsync(string filter = "mutual", UserFields fields = UserFields.None, int offset = 0, int count = 100, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("filter", filter)
                .Add("fields", fields)
                .Add("offset", offset)
                .Add("count", count)
                .ToDictionary();

            return await GetAsync<Collection<User>>("getSuggestions", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns a list of mutual friends between the source user and a target user.
        /// </summary>
        /// <param name="targetUid">Target user ID.</param>
        /// <param name="sourceUid">Source user ID (defaults to current user).</param>
        /// <param name="order">Sort order.</param>
        /// <param name="count">Number of mutual friends to return.</param>
        /// <param name="offset">Offset for pagination.</param>
        /// <param name="needCommonCount">Whether to return total common count.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="MutualFriends"/> object.</returns>
        public async Task<MutualFriends> GetMutualAsync(int targetUid, int sourceUid = 0, string order = "", int? count = null, int offset = 0, bool needCommonCount = false, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("target_uid", targetUid)
                .Add("source_uid", sourceUid)
                .Add("order", order)
                .Add("count", count)
                .Add("offset", offset)
                .Add("need_common_count", needCommonCount ? 1 : 0)
                .ToDictionary();

            return await GetAsync<MutualFriends>("getMutual", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns lists of mutual friends between the source user and multiple target users.
        /// </summary>
        /// <param name="targetUids">Target user IDs.</param>
        /// <param name="sourceUid">Source user ID (defaults to current user).</param>
        /// <param name="order">Sort order.</param>
        /// <param name="count">Number of mutual friends to return.</param>
        /// <param name="offset">Offset for pagination.</param>
        /// <param name="needCommonCount">Whether to return total common count.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="MutualFriends"/> objects.</returns>
        public async Task<List<MutualFriends>> GetMutualAsync(IEnumerable<int> targetUids, int sourceUid = 0, string order = "", int? count = null, int offset = 0, bool needCommonCount = false, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("target_uids", targetUids)
                .Add("source_uid", sourceUid)
                .Add("order", order)
                .Add("count", count)
                .Add("offset", offset)
                .Add("need_common_count", needCommonCount ? 1 : 0)
                .ToDictionary();

            return await GetAsync<List<MutualFriends>>("getMutual", parameters, cancellationToken);
        }
    }
}
