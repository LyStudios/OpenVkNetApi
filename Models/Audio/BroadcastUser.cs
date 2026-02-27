using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    public sealed class BroadcastUser : BroadcastItem
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; } = "";

        [JsonProperty("last_name")]
        public string LastName { get; set; } = "";

        [JsonProperty("deactivated")]
        public bool Deactivated { get; set; }

        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }
    }
}
