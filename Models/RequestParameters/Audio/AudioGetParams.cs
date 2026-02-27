using OpenVkNetApi.Utils;

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
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; } = 0;
        
        /// <summary>
        /// The ID of the album to retrieve audio from.
        /// </summary>
        [ApiParameter("album_id")]
        public int AlbumId { get; set; } = 0;
        
        /// <summary>
        /// A comma-separated list of audio IDs to retrieve specific tracks.
        /// </summary>
        [ApiParameter("audio_ids")]
        public string AudioIds { get; set; } = "";
        
        /// <summary>
        /// Whether to return information about owners (0 or 1).
        /// </summary>
        [ApiParameter("need_user")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool NeedUser { get; set; } = true;
        
        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;
        
        /// <summary>
        /// The number of audio files to return (maximum 2000).
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 100;
        
        /// <summary>
        /// Whether to return only uploaded tracks (0 or 1).
        /// </summary>
        [ApiParameter("uploaded_only")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool UploadedOnly { get; set; } = false;
        
        /// <summary>
        /// Whether to return a seed for shuffling.
        /// </summary>
        [ApiParameter("need_seed")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool NeedSeed { get; set; } = false;

        /// <summary>
        /// The seed for shuffling the playlist.
        /// </summary>
        [ApiParameter("shuffle_seed")]
        public string? ShuffleSeed { get; set; } = null;
        
        /// <summary>
        /// Whether to shuffle the results (0 or 1).
        /// </summary>
        [ApiParameter("shuffle")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Shuffle { get; set; } = false;

        /// <summary>
        /// The hash for the request.
        /// </summary>
        [ApiParameter("hash")]
        public string? Hash { get; set; } = null;
    }
}
