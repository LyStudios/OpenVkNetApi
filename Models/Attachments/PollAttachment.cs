using OpenVkNetApi.Models.Polls;

namespace OpenVkNetApi.Models.Attachments
{
    /// <summary>
    /// Represents a poll attachment.
    /// </summary>
    public sealed class PollAttachment : Attachment
    {
        /// <summary>
        /// Gets or sets the poll object.
        /// </summary>
        public Poll Poll { get; set; } = null;
    }
}
