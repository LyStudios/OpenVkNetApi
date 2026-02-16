using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Audio
{
    /// <summary>
    /// Parameters for the <c>audio.add</c> method.
    /// Used by <see cref="OpenVkNetApi.Methods.Audio.AddAsync"/>.
    /// </summary>
    public class AudioAddParams
    {
        /// <summary>
        /// The ID of the audio file to add.
        /// </summary>
        [JsonProperty("audio_id")]
        public int AudioId { get; set; }
        
        /// <summary>
        /// The ID of the audio file's owner.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        
        /// <summary>
        /// The community ID (if adding to a group).
        /// </summary>
        [JsonProperty("group_id")]
        public int? GroupId { get; set; }
        
        /// <summary>
        /// The ID of the album to add the audio to.
        /// </summary>
        [JsonProperty("album_id")]
        public int? AlbumId { get; set; }
    }
}
