using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Notes
{
    /// <summary>
    /// Represents a comment on a note.
    /// </summary>
    public class NoteComment
    {
        /// <summary>
        /// The comment ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The author's ID.
        /// </summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        /// <summary>
        /// The date when the comment was created, in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// The comment text.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }
    }
}
