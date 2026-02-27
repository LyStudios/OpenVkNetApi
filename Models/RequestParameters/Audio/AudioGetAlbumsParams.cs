using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Audio
{
    /// <summary>
    /// Parameters for the <c>audio.getAlbums</c> method.
    /// </summary>
    public class AudioGetAlbumsParams
    {
        /// <summary>
        /// The owner's ID.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; } = 0;

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// The number of albums to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 50;

        /// <summary>
        /// Whether to exclude private albums (0 or 1).
        /// </summary>
        [ApiParameter("drop_private")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool DropPrivate { get; set; } = true;
    }
}
