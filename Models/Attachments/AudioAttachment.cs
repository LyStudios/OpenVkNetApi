namespace OpenVkNetApi.Models.Attachments
{
    /// <summary>
    /// Represents an audio attachment.
    /// </summary>
    public sealed class AudioAttachment : Attachment
    {
        /// <summary>
        /// Gets or sets the audio object.
        /// </summary>
        public Audio.Audio Audio { get; set; } = null;
    }
}
