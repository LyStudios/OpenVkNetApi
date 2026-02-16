using OpenVkNetApi.Models.Docs;

namespace OpenVkNetApi.Models.Attachments
{
    public sealed class DocumentAttachment : Attachment
    {
        public Doc Document { get; set; } = null!;
    }
}