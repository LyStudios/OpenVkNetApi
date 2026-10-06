using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models.Queue;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for managing real-time queue notifications.
    /// Encapsulates the <c>queue.*</c> methods of the OpenVK API.
    /// </summary>
    public class Queue : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Queue"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Queue(OpenVkApi api) : base(api, "queue") { }

        /// <summary>
        /// Subscribes the current user to one or more message/event queues.
        /// </summary>
        /// <param name="queueId">Specific queue ID to subscribe to.</param>
        /// <param name="queueIds">Collection of queue IDs to subscribe to.</param>
        /// <param name="ts">Timestamp from which to receive events.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="QueueSubscribeResult"/> object.</returns>
        public async Task<QueueSubscribeResult> SubscribeAsync(string queueId = "", IEnumerable<string> queueIds = null, int ts = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("queue_id", queueId)
                .Add("queue_ids", queueIds)
                .Add("ts", ts)
                .ToDictionary();

            return await GetAsync<QueueSubscribeResult>("subscribe", parameters, ct);
        }

        /// <summary>
        /// Unsubscribes from one or more event queues.
        /// </summary>
        /// <param name="queueId">Specific queue ID to unsubscribe from.</param>
        /// <param name="queueIds">Collection of queue IDs to unsubscribe from.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A boolean indicating success.</returns>
        public async Task<bool> UnsubscribeAsync(string queueId = "", IEnumerable<string> queueIds = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("queue_id", queueId)
                .Add("queue_ids", queueIds)
                .ToDictionary();

            var result = await PostAsync<int>("unsubscribe", parameters, ct);
            return result == 1;
        }
    }
}
