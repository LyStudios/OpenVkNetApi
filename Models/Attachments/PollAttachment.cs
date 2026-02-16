using OpenVkNetApi.Models.Polls;

namespace OpenVkNetApi.Models.Attachments
{
    public sealed class PollAttachment : Attachment
    {
        public Poll Poll { get; set; } = null!;
    }
}
