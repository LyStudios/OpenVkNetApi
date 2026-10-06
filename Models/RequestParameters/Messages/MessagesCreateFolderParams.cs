using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the <c>messages.createFolder</c> method.
    /// </summary>
    public class MessagesCreateFolderParams
    {
        /// <summary>
        /// Name of the folder.
        /// </summary>
        [ApiParameter("name")]
        public string Name { get; set; }

        /// <summary>
        /// Type of the folder (e.g. "custom").
        /// </summary>
        [ApiParameter("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        /// Comma-separated list of included peer IDs.
        /// </summary>
        [ApiParameter("included_peer_ids")]
        public string IncludedPeerIds { get; set; }
    }
}
