using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Models.Groups;
using OpenVkNetApi.Models.RequestParameters.Groups;
using OpenVkNetApi.Models.Users;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with communities (groups).
    /// Encapsulates the <c>groups.*</c> methods of the OpenVK API.
    /// </summary>
    public class Groups : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Groups"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Groups(OpenVkApi api) : base(api, "groups") { }

        /// <summary>
        /// Returns a list of the user's groups.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Group}"/> of group objects.</returns>
        public async Task<Collection<Group>> GetAsync(GroupsGetParams @params, CancellationToken ct = default)
        {
            return await GetAsync<Collection<Group>>("get", @params, ct);
        }

        /// <summary>
        /// Returns information about groups by their IDs.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="Group"/> objects.</returns>
        [AllowAnonymous]
        public async Task<List<Group>> GetByIdAsync(GroupsGetByIdParams @params, CancellationToken ct = default)
        {
            return await GetAsync<List<Group>>("getById", @params, ct);
        }

        /// <summary>
        /// Searches for groups.
        /// </summary>
        /// <param name="params">Search parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Group}"/> of found group objects.</returns>
        [AllowAnonymous]
        public async Task<Collection<Group>> SearchAsync(GroupsSearchParams @params, CancellationToken ct = default)
        {
            return await GetAsync<Collection<Group>>("search", @params, ct);
        }

        /// <summary>
        /// Joins a group.
        /// </summary>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> JoinAsync(int groupId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .ToDictionary();

            return await PostAsync<int>("join", parameters, ct);
        }

        /// <summary>
        /// Leaves a group.
        /// </summary>
        /// <param name="groupId">The group ID.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> LeaveAsync(int groupId, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .ToDictionary();

            return await PostAsync<int>("leave", parameters, cancellationToken);
        }

        /// <summary>
        /// Edits a group's information.
        /// </summary>
        /// <param name="params">Parameters for the edit operation.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> EditAsync(GroupsEditParams @params, CancellationToken cancellationToken = default)
        {
            return await PostAsync<int>("edit", @params, cancellationToken);
        }

        /// <summary>
        /// Returns a list of a group's members.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{User}"/> of member objects.</returns>
        public async Task<Collection<User>> GetMembersAsync(GroupsGetMembersParams @params, CancellationToken cancellationToken = default)
        {
            return await GetAsync<Collection<User>>("getMembers", @params, cancellationToken);
        }

        /// <summary>
        /// Returns the settings of a group.
        /// </summary>
        /// <param name="groupId">The group ID.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="GroupSettings"/> object.</returns>
        public async Task<GroupSettings> GetSettingsAsync(string groupId, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .ToDictionary();

            return await GetAsync<GroupSettings>("getSettings", parameters, cancellationToken);
        }

        /// <summary>
        /// Checks if a user is a member of a group.
        /// </summary>
        /// <param name="groupId">The group ID.</param>
        /// <param name="userId">The user ID.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>1 if the user is a member, 0 otherwise.</returns>
        public async Task<int> IsMemberAsync(string groupId, int userId, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .Add("user_id", userId)
                .ToDictionary();

            return await GetAsync<int>("isMember", parameters, cancellationToken);
        }

        /// <summary>
        /// Checks if a user is a member of a group with extended information.
        /// </summary>
        /// <param name="groupId">The group ID.</param>
        /// <param name="userId">The user ID.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="GroupsIsMember"/> object containing detailed membership status information.</returns>
        public async Task<GroupsIsMember> IsMemberExtendedAsync(string groupId, int userId, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .Add("user_id", userId)
                .Add("extended", "1")
                .ToDictionary();

            return await GetAsync<GroupsIsMember>("isMember", parameters, cancellationToken);
        }

        /// <summary>
        /// Adds a user to the community blacklist (bans a member).
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="ownerId">User ID to ban.</param>
        /// <param name="reason">Ban reason code.</param>
        /// <param name="endDate">Ban end timestamp (0 for permanent).</param>
        /// <param name="comment">Ban comment / explanation.</param>
        /// <param name="commentVisible">Whether comment is visible to user.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A boolean indicating success.</returns>
        public async Task<bool> BanAsync(int groupId, int ownerId, int reason = 0, long endDate = 0, string comment = "", bool commentVisible = true, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .Add("owner_id", ownerId)
                .Add("reason", reason)
                .Add("end_date", endDate)
                .Add("comment", comment)
                .Add("comment_visible", commentVisible ? 1 : 0)
                .ToDictionary();

            var result = await PostAsync<int>("ban", parameters, ct);
            return result == 1;
        }

        /// <summary>
        /// Removes a user from the community blacklist (unbans a member).
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="ownerId">User ID to unban.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A boolean indicating success.</returns>
        public async Task<bool> UnbanAsync(int groupId, int ownerId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .Add("owner_id", ownerId)
                .ToDictionary();

            var result = await PostAsync<int>("unban", parameters, ct);
            return result == 1;
        }

        /// <summary>
        /// Returns a list of users banned in the community.
        /// </summary>
        /// <param name="groupId">Community ID.</param>
        /// <param name="offset">Offset for pagination.</param>
        /// <param name="count">Number of banned users to return.</param>
        /// <param name="fields">User fields to return.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{User}"/> of banned users.</returns>
        public async Task<Collection<User>> GetBannedAsync(int groupId, int offset = 0, int count = 20, UserFields fields = UserFields.None, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .Add("offset", offset)
                .Add("count", count)
                .Add("fields", fields)
                .ToDictionary();

            return await GetAsync<Collection<User>>("getBanned", parameters, ct);
        }
    }
}
