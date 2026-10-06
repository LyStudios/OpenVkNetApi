using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for tracking stats and metrics.
    /// Encapsulates the <c>stats.*</c> methods of the OpenVK API.
    /// </summary>
    public class Stats : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stats"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Stats(OpenVkApi api) : base(api, "stats") { }

        /// <summary>
        /// Tracks user/app client events in analytics.
        /// </summary>
        /// <param name="events">Serialized events data or event name.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A boolean indicating success.</returns>
        public async Task<bool> TrackEventsAsync(string events = "", CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("events", events)
                .ToDictionary();

            var result = await PostAsync<int>("trackEvents", parameters, ct);
            return result == 1;
        }
    }
}
