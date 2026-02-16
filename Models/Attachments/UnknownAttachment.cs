using Newtonsoft.Json.Linq;

namespace OpenVkNetApi.Models.Attachments
{
    public sealed class UnknownAttachment : Attachment
    {
        public JObject? Raw { get; set; }
    }
}
