using System.Threading.Tasks;
using OpenVkNetApi.Models.RequestParameters.Reports;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with user reports (complaints).
    /// Encapsulates the <c>reports.*</c> methods of the OpenVK API.
    /// </summary>
    public class Reports : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reports"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Reports(OpenVkApi api) : base(api, "reports") { }

        /// <summary>
        /// Sends a report (complaint) about a user, group, or content.
        /// </summary>
        /// <param name="params">Parameters for the report.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> AddAsync(ReportsAddParams @params)
        {
            return await PostAsync<int>("add", @params);
        }
    }
}
