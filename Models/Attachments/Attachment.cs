namespace OpenVkNetApi.Models.Attachments
{
    /// <summary>
    /// Represents a base class for all attachment types in OpenVK.
    /// </summary>
    public abstract class Attachment
    {
        /// <summary>
        /// Gets or sets the type of the attachment (e.g., "photo", "audio", "video", "doc", "poll", "note").
        /// </summary>
        public string Type { get; set; } = null;
    }
}
