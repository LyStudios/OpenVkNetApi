using Newtonsoft.Json;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Represents a base class for broadcast items (statuses with audio).
    /// </summary>
    [JsonConverter(typeof(BroadcastItemConverter))]
    public abstract class BroadcastItem
    {
        /// <summary>
        /// Gets or sets the broadcast item ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the audio status information.
        /// </summary>
        [JsonProperty("status_audio")]
        public Audio StatusAudio { get; set; }
    }
}
