using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with the payment system.
    /// Encapsulates the <c>pay.*</c> methods of the OpenVK API.
    /// </summary>
    public class Pay : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pay"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Pay(OpenVkApi api) : base(api, "pay") { }
        
        // This namespace seems to be highly custom and might not be fully implemented in all OpenVK instances.
        // Documentation is based on observed usage.

        /// <summary>
        /// Gets a user or group ID based on a marketing ID.
        /// </summary>
        /// <param name="marketingId">The marketing ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The user or group ID.</returns>
        public async Task<int> GetIdByMarketingIdAsync(string marketingId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("marketing_id", marketingId)
                .ToDictionary();

            return await GetAsync<int>("getIdByMarketingId", parameters, ct);
        }

        /// <summary>
        /// Verifies a payment order.
        /// </summary>
        /// <param name="appId">The application ID.</param>
        /// <param name="amount">The payment amount.</param>
        /// <param name="signature">The request signature.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>True if the order is valid, otherwise false.</returns>
        public async Task<bool> VerifyOrderAsync(int appId, float amount, string signature, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("app_id", appId)
                .Add("amount", amount)
                .Add("signature", signature)
                .ToDictionary();

            return await PostAsync<bool>("verifyOrder", parameters, ct);
        }
    }
}
