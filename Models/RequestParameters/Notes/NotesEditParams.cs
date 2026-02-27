using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Notes
{
    /// <summary>
    /// Parameters for the notes.edit method.
    /// </summary>
    public class NotesEditParams
    {
        /// <summary>
        /// ID of the note to edit.
        /// </summary>
        [ApiParameter("note_id")]
        public int NoteId { get; set; }

        /// <summary>
        /// New note title.
        /// </summary>
        [ApiParameter("title")]
        public string Title { get; set; } = "";

        /// <summary>
        /// New note text.
        /// </summary>
        [ApiParameter("text")]
        public string Text { get; set; } = "";

        /// <summary>
        /// Privacy settings for the note.
        /// </summary>
        [ApiParameter("privacy")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Privacy { get; set; } = false;

        /// <summary>
        /// Privacy settings for comments on the note.
        /// </summary>
        [ApiParameter("comment_privacy")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool CommentPrivacy { get; set; } = false;

        /// <summary>
        /// Privacy settings for viewing the note (e.g., "all", "friends").
        /// </summary>
        [ApiParameter("privacy_view")]
        public string PrivacyView { get; set; } = "";

        /// <summary>
        /// Privacy settings for commenting on the note (e.g., "all", "friends").
        /// </summary>
        [ApiParameter("privacy_comment")]
        public string PrivacyComment { get; set; } = "";
    }
}
