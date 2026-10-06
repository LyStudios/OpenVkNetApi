using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models.Apps;
using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with mini apps.
    /// Encapsulates the <c>apps.*</c> methods of the OpenVK API.
    /// </summary>
    public class Apps : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apps"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Apps(OpenVkApi api) : base(api, "apps") { }

        /// <summary>
        /// Returns the mini apps catalog.
        /// </summary>
        /// <param name="limit">Number of apps to return.</param>
        /// <param name="startFrom">Pagination start cursor.</param>
        /// <param name="ref">Referral source identifier.</param>
        /// <param name="sectionId">Catalog section ID.</param>
        /// <param name="fields">Fields to return.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="MiniAppsCatalog"/> object.</returns>
        public async Task<MiniAppsCatalog> GetMiniAppsCatalogAsync(int limit = 0, string startFrom = "", string @ref = "", int sectionId = 0, UserFields fields = UserFields.None, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("limit", limit)
                .Add("start_from", startFrom)
                .Add("ref", @ref)
                .Add("section_id", sectionId)
                .Add("fields", fields)
                .ToDictionary();

            return await GetAsync<MiniAppsCatalog>("getMiniAppsCatalog", parameters, ct);
        }

        /// <summary>
        /// Searches for mini apps in the catalog.
        /// </summary>
        /// <param name="query">Search query string.</param>
        /// <param name="limit">Number of apps to return.</param>
        /// <param name="startFrom">Pagination start cursor.</param>
        /// <param name="fields">Fields to return.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="MiniAppsCatalog"/> object containing search results.</returns>
        public async Task<MiniAppsCatalog> GetMiniAppsCatalogSearchAsync(string query = "", int limit = 0, string startFrom = "", UserFields fields = UserFields.None, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("query", query)
                .Add("limit", limit)
                .Add("start_from", startFrom)
                .Add("fields", fields)
                .ToDictionary();

            return await GetAsync<MiniAppsCatalog>("getMiniAppsCatalogSearch", parameters, ct);
        }
    }
}
