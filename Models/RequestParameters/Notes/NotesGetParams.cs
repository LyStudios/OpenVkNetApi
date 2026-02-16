using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Notes
{
    /// <summary>
    /// Parameters for the notes.get method.
    /// </summary>
    public class NotesGetParams
    {
        /// <summary>
        /// ID of the user whose notes to return.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// A comma-separated list of note IDs to return specific notes.
        /// </summary>
        [JsonProperty("note_ids")]
        public string NoteIds { get; set; } = "";

        /// <summary>
        /// Offset needed to return a specific subset of notes.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of notes to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// Sort order of notes (0 - by date, 1 - by title).
        /// </summary>
        [JsonProperty("sort")]
        public int Sort { get; set; } = 0;
    }
}
