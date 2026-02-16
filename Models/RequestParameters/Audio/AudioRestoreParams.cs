using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Audio
{
    /// <summary>
    /// Parameters for the <c>audio.restore</c> method.
    /// Used by <see cref="OpenVkNetApi.Methods.Audio.RestoreAsync"/>.
    /// </summary>
    public class AudioRestoreParams
    {
        /// <summary>
        /// The ID of the audio file to restore.
        /// </summary>
        [JsonProperty("audio_id")]
        public int AudioId { get; set; }
        
        /// <summary>
        /// The ID of the audio file's owner.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        
        /// <summary>
        /// The community ID (if restoring to a group).
        /// </summary>
        [JsonProperty("group_id")]
        public int? GroupId { get; set; } = 0;
        
        /// <summary>
        /// The hash for the request.
        /// </summary>
        [JsonProperty("hash")]
        public string? Hash { get; set; }
    }
}
