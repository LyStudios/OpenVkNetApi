using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Board
{
    /// <summary>
    /// Parameters for the board.getComments method.
    /// </summary>
    public class BoardGetCommentsParams
    {
        /// <summary>
        /// ID of the community.
        /// </summary>
        [ApiParameter("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// ID of the topic.
        /// </summary>
        [ApiParameter("topic_id")]
        public int TopicId { get; set; }

        /// <summary>
        /// True to return the 'likes' object.
        /// </summary>
        [ApiParameter("need_likes")]
        public bool NeedLikes { get; set; } = false;

        /// <summary>
        /// Offset needed to return a specific subset of comments.
        /// </summary>
        [ApiParameter("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of comments to return.
        /// </summary>
        [ApiParameter("count")]
        public int Count { get; set; } = 10;

        /// <summary>
        /// True to return extended information about users who posted comments.
        /// </summary>
        [ApiParameter("extended")]
        public bool Extended { get; set; } = false;
    }
}
