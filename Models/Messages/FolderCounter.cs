using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents counters for an individual message folder.
    /// </summary>
    public class FolderCounter
    {
        /// <summary>
        /// ID of the folder.
        /// </summary>
        [JsonProperty("folder_id")]
        public int FolderId { get; set; }

        /// <summary>
        /// Total number of messages/dialogs in the folder.
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// Number of unmuted messages/dialogs in the folder.
        /// </summary>
        [JsonProperty("unmuted_count")]
        public int UnmutedCount { get; set; }
    }
}
