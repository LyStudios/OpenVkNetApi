using OpenVkNetApi.Models.Enums;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Newsfeed
{
    /// <summary>
    /// Parameters for the newsfeed.getBanned method.
    /// </summary>
    public class NewsfeedGetBannedParams
    {
        /// <summary>
        /// 1 to return extended information about users and groups.
        /// </summary>
        [ApiParameter("extended")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Extended { get; set; } = false;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [ApiParameter("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// Case for the user's name ("nom", "gen", etc.).
        /// </summary>
        [ApiParameter("name_case")]
        public string NameCase { get; set; } = "nom";

        /// <summary>
        /// 1 to merge user and group lists.
        /// </summary>
        [ApiParameter("merge")]
        [ApiParameterFormat(ParameterFormat.IntegerFromBool)]
        public bool Merge { get; set; } = false;
    }
}
