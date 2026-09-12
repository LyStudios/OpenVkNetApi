using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents push notification settings for a conversation.
    /// </summary>
    public class ConversationPushSettings
    {
        /// <summary>
        /// Gets or sets the Unix timestamp until which notifications are disabled (-1 if forever).
        /// </summary>
        [JsonProperty("disabled_until")]
        public long DisabledUntil { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether notifications are disabled forever.
        /// </summary>
        [JsonProperty("disabled_forever")]
        public bool DisabledForever { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether sound is disabled for notifications.
        /// </summary>
        [JsonProperty("no_sound")]
        public bool NoSound { get; set; }
    }
}
