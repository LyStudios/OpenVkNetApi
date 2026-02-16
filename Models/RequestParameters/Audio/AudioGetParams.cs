using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Audio
{
    /// <summary>
    /// Parameters for the <c>audio.get</c> method.
    /// Used by <see cref="OpenVkNetApi.Methods.Audio.GetAsync"/>.
    /// </summary>
    public class AudioGetParams
    {
        /// <summary>
        /// The ID of the owner of the audio files.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; } = 0;
        
        /// <summary>
        /// The ID of the album to retrieve audio from.
        /// </summary>
        [JsonProperty("album_id")]
        public int AlbumId { get; set; } = 0;
        
        /// <summary>
        /// A comma-separated list of audio IDs to retrieve specific tracks.
        /// </summary>
        [JsonProperty("audio_ids")]
        public string? AudioIds { get; set; } = "";
        
        /// <summary>
        /// Whether to return information about owners (0 or 1).
        /// </summary>
        [JsonProperty("need_user")]
        public int NeedUser { get; set; } = 1;
        
        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;
        
        /// <summary>
        /// The number of audio files to return (maximum 2000).
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 100;
        
        /// <summary>
        /// Whether to return only uploaded tracks (0 or 1).
        /// </summary>
        [JsonProperty("uploaded_only")]
        public int UploadedOnly { get; set; } = 0;
        
        /// <summary>
        /// Whether to return a seed for shuffling.
        /// </summary>
        [JsonProperty("need_seed")]
        public int NeedSeed { get; set; } = 0;
        
        /// <summary>
        /// The seed for shuffling the playlist.
        /// </summary>
        [JsonProperty("shuffle_seed")]
        public string? ShuffleSeed { get; set; }
        
        /// <summary>
        /// Whether to shuffle the results (0 or 1).
        /// </summary>
        [JsonProperty("shuffle")]
        public int Shuffle { get; set; } = 0;
        
        /// <summary>
        /// The hash for the request.
        /// </summary>
        [JsonProperty("hash")]
        public string? Hash { get; set; }
    }
}
