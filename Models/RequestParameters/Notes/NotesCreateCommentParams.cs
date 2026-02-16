using Newtonsoft.Json;

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
        [JsonProperty("note_id")]
        public int NoteId { get; set; }

        /// <summary>
        /// ID of the note owner.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// The text of the comment.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; } = "";

        /// <summary>
        /// Attachments to the comment.
        /// </summary>
        [JsonProperty("attachments")]
        public string Attachments { get; set; } = "";
    }
}
