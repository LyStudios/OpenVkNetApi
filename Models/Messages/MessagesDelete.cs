using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Messages
{
    /// <summary>
    /// Represents the result of a messages.delete API call.
    /// The keys are message IDs and the values indicate success (1) or failure (0).
    /// </summary>
    public class MessagesDelete : Dictionary<string, int>
    {
    }
}
