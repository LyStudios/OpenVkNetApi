using Newtonsoft.Json;

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
        [JsonProperty("note_id")]
        public int NoteId { get; set; }

        /// <summary>
        /// New note title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = "";

        /// <summary>
        /// New note text.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; } = "";

        /// <summary>
        /// Privacy settings for the note.
        /// </summary>
        [JsonProperty("privacy")]
        public int Privacy { get; set; } = 0;

        /// <summary>
        /// Privacy settings for comments on the note.
        /// </summary>
        [JsonProperty("comment_privacy")]
        public int CommentPrivacy { get; set; } = 0;

        /// <summary>
        /// Privacy settings for viewing the note (e.g., "all", "friends").
        /// </summary>
        [JsonProperty("privacy_view")]
        public string PrivacyView { get; set; } = "";

        /// <summary>
        /// Privacy settings for commenting on the note (e.g., "all", "friends").
        /// </summary>
        [JsonProperty("privacy_comment")]
        public string PrivacyComment { get; set; } = "";
    }
}
