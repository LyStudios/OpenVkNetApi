using OpenVkNetApi.Utils;

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
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; } = 0;

        /// <summary>
        /// A comment explaining the report.
        /// </summary>
        [ApiParameter("comment")]
        public string Comment { get; set; } = "";

        /// <summary>
        /// The reason for the report (0 - spam, 1 - explicit, 2 - violence, etc.).
        /// </summary>
        [ApiParameter("reason")]
        public int Reason { get; set; } = 0;

        /// <summary>
        /// The type of object being reported (e.g., "post", "comment", "photo").
        /// </summary>
        [ApiParameter("type")]
        public string Type { get; set; } = "";

        /// <summary>
        /// The source of the report.
        /// </summary>
        [ApiParameter("report_source")]
        public string ReportSource { get; set; } = "";
    }
}
