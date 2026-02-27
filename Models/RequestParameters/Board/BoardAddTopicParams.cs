using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Models.RequestParameters.Board
{
    /// <summary>
    /// Parameters for the board.addTopic method.
    /// </summary>
    public class BoardAddTopicParams
    {
        /// <summary>
        /// ID of the community where the topic will be added.
        /// </summary>
        [ApiParameter("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// The title of the topic.
        /// </summary>
        [ApiParameter("title")]
        public string Title { get; set; } = null!;

        /// <summary>
        /// The text content of the topic.
        /// </summary>
        [ApiParameter("text")]
        public string? Text { get; set; } = null;

        /// <summary>
        /// True if the topic is created on behalf of the group.
        /// </summary>
        [ApiParameter("from_group")]
        public bool FromGroup { get; set; } = true;
    }
}
