using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the <c>messages.updateFolder</c> method.
    /// </summary>
    public class MessagesUpdateFolderParams
    {
        /// <summary>
        /// ID of the folder to update.
        /// </summary>
        [ApiParameter("folder_id")]
        public int FolderId { get; set; }

        /// <summary>
        /// New name of the folder.
        /// </summary>
        [ApiParameter("name")]
        public string Name { get; set; }

        /// <summary>
        /// Comma-separated list of peer IDs to add to the folder.
        /// </summary>
        [ApiParameter("add_included_peer_ids")]
        public string AddIncludedPeerIds { get; set; }

        /// <summary>
        /// Comma-separated list of peer IDs to remove from the folder.
        /// </summary>
        [ApiParameter("remove_included_peer_ids")]
        public string RemoveIncludedPeerIds { get; set; }
    }
}
