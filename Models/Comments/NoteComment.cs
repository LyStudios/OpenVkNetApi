using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Comments
{
    /// <summary>
    /// Represents a comment on a note entity.
    /// Extends the base <see cref="Comment"/> model with note-specific fields.
    /// </summary>
    public class NoteComment : Comment
    {
        /// <summary>
        /// Gets or sets the identifier of the user who authored the comment.
        /// Legacy field used in older API responses.
        /// Prefer <c>FromId</c> from the base <see cref="Comment"/> when available.
        /// </summary>
        [JsonProperty("uid")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the note to which this comment belongs.
        /// Legacy note identifier kept for backward compatibility.
        /// </summary>
        [JsonProperty("nid")]
        public int NoteId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the owner of the note.
        /// Typically matches the note author's user ID.
        /// Legacy field preserved for full API coverage.
        /// </summary>
        [JsonProperty("oid")]
        public int OwnerId { get; set; }
    }
}