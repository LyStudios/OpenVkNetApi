using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Represents a collection of audio files that includes a shuffle seed.
    /// </summary>
    /// <typeparam name="T">The type of items in the collection, typically <see cref="Audio"/>.</typeparam>
    public class AudioCollectionWithShuffle<T> : Collection<T> where T : class
    {
        /// <summary>
        /// A seed value for shuffling the playlist.
        /// </summary>
        [JsonProperty("shuffle_seed")]
        public string? ShuffleSeed { get; set; }
    }
}
