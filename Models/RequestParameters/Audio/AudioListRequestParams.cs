using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Audio
{
    /// <summary>
    /// Parameters for methods requesting a list of audio files (e.g., <c>audio.getPopular</c>).
    /// Used by <see cref="OpenVkNetApi.Methods.Audio.GetPopularAsync"/>.
    /// </summary>
    public class AudioListRequestParams
    {
        /// <summary>
        /// The genre ID.
        /// </summary>
        [JsonProperty("genre_id")]
        public int? GenreId { get; set; } = null;

        /// <summary>
        /// The genre ID as a string.
        /// </summary>
        [JsonProperty("genre_str")]
        public string? GenreStr { get; set; } = null;

        /// <summary>
        /// Offset for pagination of popular tracks.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// The number of audio files to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 100;

        /// <summary>
        /// The hash for the request.
        /// </summary>
        [JsonProperty("hash")]
        public string? Hash { get; set; } = null;
    }
}
