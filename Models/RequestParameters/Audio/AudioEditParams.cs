using OpenVkNetApi.Utils;

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
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; }
        
        /// <summary>
        /// The ID of the audio file to edit.
        /// </summary>
        [ApiParameter("audio_id")]
        public int AudioId { get; set; }
        
        /// <summary>
        /// The new artist name.
        /// </summary>
        [ApiParameter("artist")]
        public string? Artist { get; set; } = null;

        /// <summary>
        /// The new track title.
        /// </summary>
        [ApiParameter("title")]
        public string? Title { get; set; } = null;

        /// <summary>
        /// The lyrics text.
        /// </summary>
        [ApiParameter("text")]
        public string? Text { get; set; } = null;

        /// <summary>
        /// The numerical genre ID.
        /// </summary>
        [ApiParameter("genre_id")]
        public int? GenreId { get; set; } = null;
        
        /// <summary>
        /// The genre name string.
        /// </summary>
        [ApiParameter("genre_str")]
        public string? GenreStr { get; set; } = null;
        
        /// <summary>
        /// Whether to exclude the record from search results (0 or 1).
        /// </summary>
        [ApiParameter("no_search")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool NoSearch { get; set; } = false;
    }
}
