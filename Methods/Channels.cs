using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models.Channels;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with channels.
    /// Encapsulates the <c>channels.*</c> methods of the OpenVK API.
    /// </summary>
    public class Channels : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Channels"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Channels(OpenVkApi api) : base(api, "channels") { }

        /// <summary>
        /// Returns reaction mappings configured for channels.
        /// </summary>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="ChannelReactionsMapping"/> object.</returns>
        public async Task<ChannelReactionsMapping> GetReactionsMappingAsync(CancellationToken ct = default)
        {
            return await GetAsync<ChannelReactionsMapping>("getReactionsMapping", null, ct);
        }
    }
}
