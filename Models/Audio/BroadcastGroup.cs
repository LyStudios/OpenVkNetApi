using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Represents a community/group broadcasting audio.
    /// </summary>
    public sealed class BroadcastGroup : BroadcastItem
    {
        /// <summary>
        /// Gets or sets the name of the group.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = "";

        /// <summary>
        /// Gets or sets the screen name (short address) of the group.
        /// </summary>
        [JsonProperty("screen_name")]
        public string ScreenName { get; set; } = "";

        /// <summary>
        /// Gets or sets a value indicating whether the group is closed (private).
        /// </summary>
        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Gets or sets the type of the community (e.g., "group", "page", "event").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = "";

        /// <summary>
        /// Gets or sets a value indicating whether the current user can access the closed group.
        /// </summary>
        [JsonProperty("can_access_closed")]
        public bool CanAccessClosed { get; set; }
    }
}
