using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents the sort identifier used in conversations for ordering messages.
    /// </summary>
    public class SortId
    {
        /// <summary>
        /// The major part of the sort ID, typically representing the conversation or thread.
        /// </summary>
        [JsonProperty("major_id")]
        public int MajorId { get; set; }

        /// <summary>
        /// The minor part of the sort ID, typically representing the message within the conversation.
        /// </summary>
        [JsonProperty("minor_id")]
        public int MinorId { get; set; }
    }
}
