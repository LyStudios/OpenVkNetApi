using Newtonsoft.Json;
using OpenVkNetApi.Models.Users;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents the response from methods that return a list of photo comments.
    /// </summary>
    public class PhotosComments : Collection<PhotoComment>
    {
        /// <summary>
        /// A list of user profiles for the authors of the comments.
        /// </summary>
        [JsonProperty("profiles")]
        public List<User>? Profiles { get; set; }
    }
}
