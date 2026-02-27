using Newtonsoft.Json;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.Audio
{
    [JsonConverter(typeof(BroadcastItemConverter))]
    public abstract class BroadcastItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status_audio")]
        public Audio? StatusAudio { get; set; }
    }
}
