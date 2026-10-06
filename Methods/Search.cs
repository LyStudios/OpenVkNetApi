using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models.Search;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides search helper methods.
    /// Encapsulates the <c>search.*</c> methods of the OpenVK API.
    /// </summary>
    public class Search : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Search"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Search(OpenVkApi api) : base(api, "search") { }

        /// <summary>
        /// Returns search hints and suggestions.
        /// </summary>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A list of search hints.</returns>
        public async Task<List<SearchHint>> GetHintsAsync(CancellationToken ct = default)
        {
            return await GetAsync<List<SearchHint>>("getHints", null, ct);
        }
    }
}
