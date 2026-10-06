using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models.Attachments;
using OpenVkNetApi.Models.Users;
using OpenVkNetApi.Models.Utils;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides utility methods.
    /// Encapsulates the <c>utils.*</c> methods of the OpenVK API.
    /// </summary>
    public class Utils : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Utils"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Utils(OpenVkApi api) : base(api, "utils") { }

        /// <summary>
        /// Returns the current time on the API server.
        /// </summary>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The server time in Unix format.</returns>
        [AllowAnonymous]
        public async Task<long> GetServerTimeAsync(CancellationToken ct = default)
        {
            return await GetAsync<long>("getServerTime", null, ct);
        }

        /// <summary>
        /// Resolves a screen name (short name) into an object ID and type.
        /// </summary>
        /// <param name="screenName">The screen name to resolve.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="UtilsResolveScreenName"/> object with the result.</returns>
        [AllowAnonymous]
        public async Task<UtilsResolveScreenName> ResolveScreenNameAsync(string screenName, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("screen_name", screenName)
                .ToDictionary();

            return await GetAsync<UtilsResolveScreenName>("resolveScreenName", parameters, ct);
        }

        /// <summary>
        /// Resolves a GUID to a user's profile information.
        /// </summary>
        /// <param name="guid">The GUID to resolve.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="User"/> object.</returns>
        [AllowAnonymous]
        public async Task<User> ResolveGuidAsync(string guid, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("guid", guid)
                .ToDictionary();

            return await GetAsync<User>("resolveGuid", parameters, ct);
        }

        /// <summary>
        /// Resolves raw attachment strings into structured attachment objects.
        /// </summary>
        public async Task<List<Attachment>> ResolveAttachmentsAsync(string attachments, int allowType = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("attachments", attachments)
                .Add("allow_type", allowType)
                .ToDictionary();

            return await GetAsync<List<Attachment>>("resolveAttachments", parameters, ct);
        }

        /// <summary>
        /// Calculates the exact pagination offset for a specific target object.
        /// </summary>
        public async Task<int> ResolveOffsetAsync(int ownerId, int id, int? id2 = null, string method = "wall.get", int perPage = 10, bool rev = false, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("id", id)
                .Add("id2", id2)
                .Add("method", method)
                .Add("perPage", perPage)
                .Add("rev", rev ? 1 : 0)
                .ToDictionary();

            return await GetAsync<int>("resolveOffset", parameters, ct);
        }
    }
}
