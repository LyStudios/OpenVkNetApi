using OpenVkNetApi.Utils;

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
        [ApiParameter("genre_id")]
        public int? GenreId { get; set; } = null;

        /// <summary>
        /// The genre ID as a string.
        /// </summary>
        [ApiParameter("genre_str")]
        public string GenreStr { get; set; } = null;

        /// <summary>
        /// Offset for pagination of popular tracks.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// The number of audio files to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 100;

        /// <summary>
        /// The hash for the request.
        /// </summary>
        [ApiParameter("hash")]
        public string Hash { get; set; } = null;
    }
}
