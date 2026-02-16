using OpenVkNetApi.Models.Photos;

namespace OpenVkNetApi.Models.Attachments
{
    public sealed class PhotoAttachment : Attachment
    {
        public Photo Photo { get; set; } = null!;
    }
}