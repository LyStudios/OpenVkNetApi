using OpenVkNetApi.Models.Notes;

namespace OpenVkNetApi.Models.Attachments
{
    public sealed class NoteAttachment : Attachment
    {
        public Note Note { get; set; } = null!;
    }
}
