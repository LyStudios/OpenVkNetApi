namespace OpenVkNetApi.Models.Attachments
{
    public sealed class VideoAttachment : Attachment
    {
        public Video.Video Video { get; set; } = null!;
    }
}
