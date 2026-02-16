using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.RequestParameters.Video;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with videos.
    /// Encapsulates the <c>video.*</c> methods of the OpenVK API.
    /// </summary>
    public class Video : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Video"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Video(OpenVkApi api) : base(api, "video") { }

        /// <summary>
        /// Returns a list of videos.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <returns>An <see cref="ExtendedCollection{Video}"/> of video objects.</returns>
        public async Task<ExtendedCollection<Models.Video.Video>> GetAsync(VideoGetParams @params)
        {
            return await GetAsync<ExtendedCollection<Models.Video.Video>>("get", @params);
        }

        /// <summary>
        /// Searches for videos.
        /// </summary>
        /// <param name="params">Search parameters.</param>
        /// <returns>An <see cref="ExtendedCollection{Video}"/> of found video objects.</returns>
        public async Task<ExtendedCollection<Models.Video.Video>> SearchAsync(VideoSearchParams @params)
        {
            return await GetAsync<ExtendedCollection<Models.Video.Video>>("search", @params);
        }
    }
}
