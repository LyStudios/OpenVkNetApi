using OpenVkNetApi.Models.Notes;

namespace OpenVkNetApi.Models.Attachments
{
    /// <summary>
    /// Represents a note attachment.
    /// </summary>
    public sealed class NoteAttachment : Attachment
    {
        /// <summary>
        /// Gets or sets the note object.
        /// </summary>
        public Note Note { get; set; } = null;
    }
}
