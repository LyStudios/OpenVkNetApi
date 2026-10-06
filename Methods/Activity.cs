using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for managing user activity status.
    /// Encapsulates the <c>activity.*</c> methods of the OpenVK API.
    /// </summary>
    public class Activity : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Activity(OpenVkApi api) : base(api, "activity") { }

        /// <summary>
        /// Updates the current user's online status with platform detection.
        /// </summary>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> OnlineAsync(CancellationToken ct = default)
        {
            return await GetAsync<int>("online", cancellationToken: ct);
        }
    }
}
