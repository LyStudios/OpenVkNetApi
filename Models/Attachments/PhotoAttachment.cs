using OpenVkNetApi.Models.Photos;

namespace OpenVkNetApi.Models.Attachments
{
    /// <summary>
    /// Represents a photo attachment.
    /// </summary>
    public sealed class PhotoAttachment : Attachment
    {
        /// <summary>
        /// Gets or sets the photo object.
        /// </summary>
        public Photo Photo { get; set; } = null;
    }
}