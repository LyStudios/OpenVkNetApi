using Newtonsoft.Json.Linq;

namespace OpenVkNetApi.Models.Attachments
{
    /// <summary>
    /// Represents an attachment of a type that is not explicitly supported by the library yet.
    /// </summary>
    public sealed class UnknownAttachment : Attachment
    {
        /// <summary>
        /// Gets or sets the raw JSON object representing the attachment.
        /// </summary>
        public JObject Raw { get; set; }
    }
}
