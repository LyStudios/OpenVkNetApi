using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Reports
{
    /// <summary>
    /// Parameters for the reports.add method.
    /// </summary>
    public class ReportsAddParams
    {
        /// <summary>
        /// ID of the object owner.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; } = 0;

        /// <summary>
        /// A comment explaining the report.
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; } = "";

        /// <summary>
        /// The reason for the report (0 - spam, 1 - explicit, 2 - violence, etc.).
        /// </summary>
        [JsonProperty("reason")]
        public int Reason { get; set; } = 0;

        /// <summary>
        /// The type of object being reported (e.g., "post", "comment", "photo").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = "";

        /// <summary>
        /// The source of the report.
        /// </summary>
        [JsonProperty("report_source")]
        public string ReportSource { get; set; } = "";
    }
}
