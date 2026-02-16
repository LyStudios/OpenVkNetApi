using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Likes;
using OpenVkNetApi.Models.RequestParameters.Likes;
using OpenVkNetApi.Models.Users;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with likes.
    /// Encapsulates the <c>likes.*</c> methods of the OpenVK API.
    /// </summary>
    public class Likes : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Likes"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Likes(OpenVkApi api) : base(api, "likes") { }

        /// <summary>
        /// Adds a 'like' to an object.
        /// </summary>
        /// <param name="type">The object type (e.g., "post", "comment", "photo").</param>
        /// <param name="ownerId">The object owner's ID.</param>
        /// <param name="itemId">The object's ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="LikesAdd"/> object with the new total likes count.</returns>
        public async Task<LikesAdd> AddAsync(string type, int ownerId, int itemId, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId.ToString(),
                ["item_id"] = itemId.ToString()
            };
            return await PostAsync<LikesAdd>("add", parameters, ct);
        }
        
        /// <summary>
        /// Removes a 'like' from an object.
        /// </summary>
        /// <param name="type">The object type (e.g., "post", "comment", "photo").</param>
        /// <param name="ownerId">The object owner's ID.</param>
        /// <param name="itemId">The object's ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="LikesAdd"/> object with the new total likes count.</returns>
        public async Task<LikesAdd> DeleteAsync(string type, int ownerId, int itemId, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["type"] = type,
                ["owner_id"] = ownerId.ToString(),
                ["item_id"] = itemId.ToString()
            };
            return await PostAsync<LikesAdd>("delete", parameters, ct);
        }

        /// <summary>
        /// Checks if the current user has 'liked' an object.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="LikesIsLiked"/> object with the result.</returns>
        public async Task<LikesIsLiked> IsLikedAsync(LikesIsLikedParams @params, CancellationToken ct = default)
        {
            return await GetAsync<LikesIsLiked>("isLiked", @params, ct);
        }

        /// <summary>
        /// Returns a list of user IDs who have 'liked' an object.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Int32}"/> of user IDs.</returns>
        public async Task<Collection<int>> GetListAsync(LikesGetListParams @params, CancellationToken ct = default)
        {
            @params.Extended = false;
            return await GetAsync<Collection<int>>("getList", @params, ct);
        }

        /// <summary>
        /// Returns an extended list of users who have 'liked' an object.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{User}"/> of user objects.</returns>
        public async Task<Collection<User>> GetListExtendedAsync(LikesGetListParams @params, CancellationToken ct = default)
        {
            @params.Extended = true;
            return await GetAsync<Collection<User>>("getList", @params, ct);
        }
    }
}
