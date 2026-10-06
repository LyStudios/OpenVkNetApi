using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models.Calls;
using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with calls.
    /// Encapsulates the <c>calls.*</c> methods of the OpenVK API.
    /// </summary>
    public class Calls : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Calls"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Calls(OpenVkApi api) : base(api, "calls") { }

        /// <summary>
        /// Returns call history for the current user.
        /// </summary>
        /// <param name="count">Number of calls to return.</param>
        /// <param name="startMessageId">Message ID from which to start pagination.</param>
        /// <param name="fields">User profile fields to return.</param>
        /// <param name="extended">Whether to return extended profiles and groups.</param>
        /// <param name="nextPagePaginationMarker">Pagination marker.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="CallsHistory"/> object.</returns>
        public async Task<CallsHistory> GetHistoryAsync(int count = 20, int startMessageId = 0, UserFields fields = UserFields.None, bool extended = false, string nextPagePaginationMarker = "", CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("count", count)
                .Add("start_message_id", startMessageId)
                .Add("fields", fields)
                .Add("extended", extended ? 1 : 0)
                .Add("next_page_pagination_marker", nextPagePaginationMarker)
                .ToDictionary();

            return await GetAsync<CallsHistory>("getHistory", parameters, ct);
        }
    }
}
