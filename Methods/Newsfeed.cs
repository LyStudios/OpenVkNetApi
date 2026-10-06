using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Models.Newsfeed;
using OpenVkNetApi.Models.RequestParameters.Newsfeed;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with the newsfeed.
    /// Encapsulates the <c>newsfeed.*</c> methods of the OpenVK API.
    /// </summary>
    public class Newsfeed : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Newsfeed"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Newsfeed(OpenVkApi api) : base(api, "newsfeed") { }

        /// <summary>
        /// Returns the current user's newsfeed.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        public async Task<NewsfeedCollection<Post>> GetAsync(NewsfeedGetParams @params)
        {
            return await GetAsync<NewsfeedCollection<Post>>("get", @params);
        }

        /// <summary>
        /// Returns the global newsfeed.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        public async Task<NewsfeedCollection<Post>> GetGlobalAsync(NewsfeedGetGlobalParams @params)
        {
            return await GetAsync<NewsfeedCollection<Post>>("getGlobal", @params);
        }

        /// <summary>
        /// Returns recommended posts.
        /// Alias of <see cref="GetGlobalAsync"/>.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        public async Task<NewsfeedCollection<Post>> GetRecommendedAsync(NewsfeedGetGlobalParams @params)
        {
            return await GetAsync<NewsfeedCollection<Post>>("getRecommended", @params);
        }

        /// <summary>
        /// Returns a newsfeed filtered by a specific type.
        /// </summary>
        /// <param name="params">Parameters for the request, including the type.</param>
        public async Task<NewsfeedCollection<Post>> GetByTypeAsync(NewsfeedGetByTypeParams @params)
        {
            return await GetAsync<NewsfeedCollection<Post>>("getByType", @params);
        }

        /// <summary>
        /// Returns a list of users and communities banned from the current user's newsfeed.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        public async Task<NewsfeedGetBanned> GetBannedAsync(NewsfeedGetBannedParams @params)
        {
            return await GetAsync<NewsfeedGetBanned>("getBanned", @params);
        }

        /// <summary>
        /// Adds users or communities to the newsfeed ban list.
        /// </summary>
        /// <param name="userIds">A comma-separated list of user IDs.</param>
        /// <param name="groupIds">A comma-separated list of group IDs.</param>
        public async Task<int> AddBanAsync(string userIds = "", string groupIds = "")
        {
            var parameters = new RequestParams()
                .Add("user_ids", userIds)
                .Add("group_ids", groupIds)
                .ToDictionary();

            return await PostAsync<int>("addBan", parameters);
        }

        /// <summary>
        /// Removes users or communities from the newsfeed ban list.
        /// </summary>
        /// <param name="userIds">A comma-separated list of user IDs.</param>
        /// <param name="groupIds">A comma-separated list of group IDs.</param>
        public async Task<int> DeleteBanAsync(string userIds = "", string groupIds = "")
        {
            var parameters = new RequestParams()
                .Add("user_ids", userIds)
                .Add("group_ids", groupIds)
                .ToDictionary();

            return await PostAsync<int>("deleteBan", parameters);
        }

        /// <summary>
        /// Searches for posts by keyword or phrase.
        /// </summary>
        /// <param name="params">Search parameters.</param>
        [AllowAnonymous]
        public async Task<NewsfeedCollection<Post>> SearchAsync(NewsfeedSearchParams @params)
        {
            return await GetAsync<NewsfeedCollection<Post>>("search", @params);
        }

        /// <summary>
        /// Returns comments on posts and photos in the newsfeed.
        /// </summary>
        public async Task<NewsfeedCollection<Post>> GetCommentsAsync(int count = 30, string filters = "post", string reposts = "", int startTime = 0, int endTime = 0, int lastComments = 1, int lastCommentsCount = 1, string startFrom = "", UserFields fields = UserFields.None, int offset = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("count", count)
                .Add("filters", filters)
                .Add("reposts", reposts)
                .Add("start_time", startTime)
                .Add("end_time", endTime)
                .Add("last_comments", lastComments)
                .Add("last_comments_count", lastCommentsCount)
                .Add("start_from", startFrom)
                .Add("fields", fields)
                .Add("offset", offset)
                .ToDictionary();

            return await GetAsync<NewsfeedCollection<Post>>("getComments", parameters, ct);
        }

        /// <summary>
        /// Returns custom newsfeed lists.
        /// </summary>
        public async Task<Collection<string>> GetListsAsync(CancellationToken ct = default)
        {
            return await GetAsync<Collection<string>>("getLists", null, ct);
        }
    }
}
