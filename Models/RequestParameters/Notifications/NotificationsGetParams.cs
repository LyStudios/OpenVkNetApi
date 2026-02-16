using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Notifications
{
    /// <summary>
    /// Parameters for the notifications.get method.
    /// </summary>
    public class NotificationsGetParams
    {
        /// <summary>
        /// Number of notifications to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// Returns a token to get the next page of notifications.
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; } = "";

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// The 'start_from' value obtained from the previous request for pagination.
        /// </summary>
        [JsonProperty("start_from")]
        public string StartFrom { get; set; } = "";

        /// <summary>
        /// A comma-separated list of filters to apply to notifications (e.g., "mentions,likes").
        /// </summary>
        [JsonProperty("filters")]
        public string Filters { get; set; } = "";

        /// <summary>
        /// Unix timestamp to start returning notifications from.
        /// </summary>
        [JsonProperty("start_time")]
        public int StartTime { get; set; } = 0;

        /// <summary>
        /// Unix timestamp to end returning notifications from.
        /// </summary>
        [JsonProperty("end_time")]
        public int EndTime { get; set; } = 0;

        /// <summary>
        /// 1 to return archived notifications.
        /// </summary>
        [JsonProperty("archived")]
        public int Archived { get; set; } = 0;
    }
}
