using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents a legacy VK / OpenVK chat object.
    /// </summary>
    public class Chat
    {
        /// <summary>
        /// Gets or sets the chat ID.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the dialog (always "chat").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the chat title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the ID of the chat creator/admin.
        /// </summary>
        [JsonProperty("admin_id")]
        public long AdminId { get; set; }

        /// <summary>
        /// Gets or sets the list of user IDs participating in the chat.
        /// </summary>
        [JsonProperty("users")]
        public List<long> Users { get; set; }

        /// <summary>
        /// Gets or sets the number of members in the chat.
        /// </summary>
        [JsonProperty("members_count")]
        public int MembersCount { get; set; }

        /// <summary>
        /// Gets or sets push notification settings for the chat.
        /// </summary>
        [JsonProperty("push_settings")]
        public ConversationPushSettings PushSettings { get; set; }

        /// <summary>
        /// Gets or sets the 50px photo URL.
        /// </summary>
        [JsonProperty("photo_50")]
        public string Photo50 { get; set; }

        /// <summary>
        /// Gets or sets the 100px photo URL.
        /// </summary>
        [JsonProperty("photo_100")]
        public string Photo100 { get; set; }

        /// <summary>
        /// Gets or sets the 200px photo URL.
        /// </summary>
        [JsonProperty("photo_200")]
        public string Photo200 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current user left the chat.
        /// </summary>
        [JsonProperty("left")]
        public int Left { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current user was kicked from the chat.
        /// </summary>
        [JsonProperty("kicked")]
        public int Kicked { get; set; }
    }
}
