using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    public sealed class BroadcastGroup : BroadcastItem
    {
        [JsonProperty("name")]
        public string Name { get; set; } = "";

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; } = "";

        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; } = "";

        [JsonProperty("can_access_closed")]
        public bool CanAccessClosed { get; set; }
    }
}
