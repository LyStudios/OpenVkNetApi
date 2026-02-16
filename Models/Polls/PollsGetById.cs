using Newtonsoft.Json;
using System.Collections.Generic;
using OpenVkNetApi.Models.Users;

namespace OpenVkNetApi.Models.Polls
{
    /// <summary>
    /// Represents the extended response from the polls.getById method.
    /// </summary>
    public class PollsGetById : Poll
    {
        /// <summary>
        /// A list of user profiles, if 'extended' was set to true.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User>? Profiles { get; set; }
    }
}
