namespace OpenVkNetApi.Models.Attachments
{
    /// <summary>
    /// Represents a video attachment.
    /// </summary>
    public sealed class VideoAttachment : Attachment
    {
        /// <summary>
        /// Gets or sets the video object.
        /// </summary>
        public Video.Video Video { get; set; } = null;
    }
}
