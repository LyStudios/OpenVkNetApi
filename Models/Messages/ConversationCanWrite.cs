using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Describes whether the current user can write to a conversation.
    /// </summary>
    public class ConversationCanWrite
    {
        /// <summary>
        /// Indicates if writing is allowed.
        /// </summary>
        [JsonProperty("allowed")]
        public bool Allowed { get; set; }
    }
}
