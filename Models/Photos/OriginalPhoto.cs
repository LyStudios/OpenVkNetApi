using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Photos
{
    public class OriginalPhoto
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}
