using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the <c>messages.reorderFolders</c> method.
    /// </summary>
    public class MessagesReorderFoldersParams
    {
        /// <summary>
        /// Comma-separated list of folder IDs in the desired order.
        /// </summary>
        [ApiParameter("folder_ids")]
        public string FolderIds { get; set; }
    }
}
