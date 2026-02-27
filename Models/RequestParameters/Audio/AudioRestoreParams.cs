using OpenVkNetApi.Utils;

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
        [ApiParameter("audio_id")]
        public int AudioId { get; set; }
        
        /// <summary>
        /// The ID of the audio file's owner.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; }
        
        /// <summary>
        /// The community ID (if restoring to a group).
        /// </summary>
        [ApiParameter("group_id")]
        public int? GroupId { get; set; } = null;
        
        /// <summary>
        /// The hash for the request.
        /// </summary>
        [ApiParameter("hash")]
        public string? Hash { get; set; } = null;
    }
}
