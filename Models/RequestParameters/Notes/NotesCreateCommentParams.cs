using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Notes
{
    /// <summary>
    /// Parameters for the notes.createComment method.
    /// </summary>
    public class NotesCreateCommentParams
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
        /// The text of the comment.
        /// </summary>
        [ApiParameter("message")]
        public string Message { get; set; } = null!;

        /// <summary>
        /// Attachments to the comment.
        /// </summary>
        [ApiParameter("attachments")]
        public string Attachments { get; set; } = "";
    }
}
