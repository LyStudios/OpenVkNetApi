using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Messages
{
    /// <summary>
    /// Parameters for the <c>messages.getFolders</c> method.
    /// </summary>
    public class MessagesGetFoldersParams
    {
        /// <summary>
        /// 1 to return peers information inside folders.
        /// </summary>
        [ApiParameter("with_peers")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool WithPeers { get; set; } = false;

        /// <summary>
        /// Additional profile fields to return.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;
    }
}
