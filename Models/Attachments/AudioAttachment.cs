namespace OpenVkNetApi.Models.Attachments
{
    public sealed class AudioAttachment : Attachment
    {
        public Audio.Audio Audio { get; set; } = null!;
    }
}
