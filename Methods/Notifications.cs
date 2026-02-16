using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Notifications;
using OpenVkNetApi.Models.RequestParameters.Notifications;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with notifications.
    /// Encapsulates the <c>notifications.*</c> methods of the OpenVK API.
    /// </summary>
    public class Notifications : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notifications"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Notifications(OpenVkApi api) : base(api, "notifications") { }

        /// <summary>
        /// Returns a list of notifications for the current user.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <returns>An <see cref="ExtendedNotificationsCollection{Notification}"/> of notification objects.</returns>
        public async Task<ExtendedNotificationsCollection<Notification>> GetAsync(NotificationsGetParams @params)
        {
            return await GetAsync<ExtendedNotificationsCollection<Notification>>("get", @params);
        }

        /// <summary>
        /// Marks all notifications as viewed.
        /// </summary>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> MarkAsViewedAsync()
        {
            return await PostAsync<int>("markAsViewed");
        }
    }
}
