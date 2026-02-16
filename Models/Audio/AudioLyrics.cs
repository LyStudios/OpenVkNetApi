using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Represents the lyrics for an audio file.
    /// Used in <see cref="OpenVkNetApi.Methods.Audio.GetLyricsAsync"/>.
    /// </summary>
    public class AudioLyrics
    {
        /// <summary>
        /// The lyrics ID.
        /// </summary>
        [JsonProperty("lyrics_id")]
        public int LyricsId { get; set; }
        
        /// <summary>
        /// The text of the lyrics.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }
    }
}
