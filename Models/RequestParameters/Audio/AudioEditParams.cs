using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Audio
{
    /// <summary>
    /// Parameters for the <c>audio.edit</c> method.
    /// Used by <see cref="OpenVkNetApi.Methods.Audio.EditAsync"/>.
    /// </summary>
    public class AudioEditParams
    {
        /// <summary>
        /// The ID of the audio file's owner.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        
        /// <summary>
        /// The ID of the audio file to edit.
        /// </summary>
        [JsonProperty("audio_id")]
        public int AudioId { get; set; }
        
        /// <summary>
        /// The new artist name.
        /// </summary>
        [JsonProperty("artist")]
        public string? Artist { get; set; }
        
        /// <summary>
        /// The new track title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }
        
        /// <summary>
        /// The lyrics text.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }
        
        /// <summary>
        /// The numerical genre ID.
        /// </summary>
        [JsonProperty("genre_id")]
        public int? GenreId { get; set; } = null;
        
        /// <summary>
        /// The genre name string.
        /// </summary>
        [JsonProperty("genre_str")]
        public string? GenreStr { get; set; } = null;
        
        /// <summary>
        /// Whether to exclude the record from search results (0 or 1).
        /// </summary>
        [JsonProperty("no_search")]
        public int NoSearch { get; set; } = 0;
    }
}
