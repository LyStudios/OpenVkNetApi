using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models.Gifts;
using OpenVkNetApi.Models.RequestParameters.Gifts;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with gifts.
    /// Encapsulates the <c>gifts.*</c> methods of the OpenVK API.
    /// </summary>
    public class Gifts : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Gifts"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Gifts(OpenVkApi api) : base(api, "gifts") { }

        /// <summary>
        /// Returns a list of a user's gifts.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <param name="count">The number of gifts to return.</param>
        /// <param name="offset">The offset for pagination.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="UserGift"/> objects.</returns>
        public async Task<List<UserGift>> GetAsync(int userId = 0, int count = 10, int offset = 0, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["user_id"] = userId.ToString(),
                ["count"] = count.ToString(),
                ["offset"] = offset.ToString()
            };
            return await GetAsync<List<UserGift>>("get", parameters, cancellationToken);
        }

        /// <summary>
        /// Sends a gift to a user.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="GiftsSend"/> object with the result.</returns>
        public async Task<GiftsSend> SendAsync(GiftsSendParams @params, CancellationToken cancellationToken = default)
        {
            return await PostAsync<GiftsSend>("send", @params, cancellationToken);
        }

        /// <summary>
        /// Returns a list of gift categories.
        /// </summary>
        /// <param name="extended">True to return extended category information.</param>
        /// <param name="page">The page number for pagination.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="GiftCategory"/> objects.</returns>
        public async Task<List<GiftCategory>> GetCategoriesAsync(bool extended = false, int page = 1, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["extended"] = extended ? "1" : "0",
                ["page"] = page.ToString()
            };
            return await GetAsync<List<GiftCategory>>("getCategories", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns a list of gifts within a specific category.
        /// </summary>
        /// <param name="id">The category ID.</param>
        /// <param name="page">The page number for pagination.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="CatalogGift"/> objects.</returns>
        public async Task<List<CatalogGift>> GetGiftsInCategoryAsync(int id, int page = 1, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["id"] = id.ToString(),
                ["page"] = page.ToString()
            };
            return await GetAsync<List<CatalogGift>>("getGiftsInCategory", parameters, cancellationToken);
        }
    }
}
