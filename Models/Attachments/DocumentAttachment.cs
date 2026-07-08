using OpenVkNetApi.Models.Docs;

namespace OpenVkNetApi.Models.Attachments
{
    /// <summary>
    /// Represents a document attachment.
    /// </summary>
    public sealed class DocumentAttachment : Attachment
    {
        /// <summary>
        /// Gets or sets the document object.
        /// </summary>
        public Doc Document { get; set; } = null;
    }
}