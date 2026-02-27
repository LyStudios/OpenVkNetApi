using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Notes
{
    /// <summary>
    /// Parameters for the notes.getComments method.
    /// </summary>
    public class NotesGetCommentsParams
    {
        /// <summary>
        /// ID of the note.
        /// </summary>
        [ApiParameter("note_id")]
        public int NoteId { get; set; }

        /// <summary>
        /// ID of the note owner.
        /// </summary>
        [ApiParameter("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Sort order of comments (1 for chronological, 0 for reverse chronological).
        /// </summary>
        [ApiParameter("sort")]
        public int Sort { get; set; } = 1;

        /// <summary>
        /// Offset needed to return a specific subset of comments.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of comments to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 100;
    }
}
