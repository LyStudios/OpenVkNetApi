using System.Collections.Generic;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
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
        public async Task<NewsfeedCollection<NewsfeedPost>> GetAsync(NewsfeedGetParams @params)
        {
            return await GetAsync<NewsfeedCollection<NewsfeedPost>>("get", @params);
        }

        /// <summary>
        /// Returns the global newsfeed.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        public async Task<NewsfeedCollection<NewsfeedPost>> GetGlobalAsync(NewsfeedGetGlobalParams @params)
        {
            return await GetAsync<NewsfeedCollection<NewsfeedPost>>("getGlobal", @params);
        }

        /// <summary>
        /// Returns a newsfeed filtered by a specific type.
        /// </summary>
        /// <param name="params">Parameters for the request, including the type.</param>
        public async Task<NewsfeedCollection<NewsfeedPost>> GetByTypeAsync(NewsfeedGetByTypeParams @params)
        {
            return await GetAsync<NewsfeedCollection<NewsfeedPost>>("getByType", @params);
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
            var parameters = new Dictionary<string, string>
            {
                ["user_ids"] = userIds,
                ["group_ids"] = groupIds
            };
            return await PostAsync<int>("addBan", parameters);
        }

        /// <summary>
        /// Removes users or communities from the newsfeed ban list.
        /// </summary>
        /// <param name="userIds">A comma-separated list of user IDs.</param>
        /// <param name="groupIds">A comma-separated list of group IDs.</param>
        public async Task<int> DeleteBanAsync(string userIds = "", string groupIds = "")
        {
            var parameters = new Dictionary<string, string>
            {
                ["user_ids"] = userIds,
                ["group_ids"] = groupIds
            };
            return await PostAsync<int>("deleteBan", parameters);
        }
    }
}
