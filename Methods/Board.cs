using OpenVkNetApi.Utils;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using OpenVkNetApi.Models.Board;
using OpenVkNetApi.Models.RequestParameters.Board;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with community boards.
    /// Encapsulates the <c>board.*</c> methods of the OpenVK API.
    /// </summary>
    public class Board : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Board"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Board(OpenVkApi api) : base(api, "board") { }

        /// <summary>
        /// Creates a new topic on a community's board.
        /// </summary>
        /// <param name="params">Parameters for the topic creation.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>The ID of the created topic.</returns>
        public async Task<int> AddTopicAsync(BoardAddTopicParams @params, CancellationToken cancellationToken = default)
        {
            return await PostAsync<int>("addTopic", @params, cancellationToken);
        }

        /// <summary>
        /// Closes a topic on a community's board.
        /// </summary>
        /// <param name="groupId">The community ID.</param>
        /// <param name="topicId">The topic ID.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> CloseTopicAsync(int groupId, int topicId, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["group_id"] = groupId.ToString(),
                ["topic_id"] = topicId.ToString()
            };
            return await PostAsync<int>("closeTopic", parameters, cancellationToken);
        }

        /// <summary>
        /// Adds a new comment on a topic on a community's board.
        /// </summary>
        /// <param name="params">Parameters for the comment creation.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>The ID of the created comment.</returns>
        public async Task<int> CreateCommentAsync(BoardCreateCommentParams @params, CancellationToken cancellationToken = default)
        {
            return await PostAsync<int>("createComment", @params, cancellationToken);
        }

        /// <summary>
        /// Deletes a topic on a community's board.
        /// </summary>
        /// <param name="groupId">The community ID.</param>
        /// <param name="topicId">The topic ID.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> DeleteTopicAsync(int groupId, int topicId, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["group_id"] = groupId.ToString(),
                ["topic_id"] = topicId.ToString()
            };
            return await PostAsync<int>("deleteTopic", parameters, cancellationToken);
        }

        /// <summary>
        /// Edits a topic on a community's board.
        /// </summary>
        /// <param name="groupId">The community ID.</param>
        /// <param name="topicId">The topic ID.</param>
        /// <param name="title">The new topic title.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> EditTopicAsync(int groupId, int topicId, string title, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["group_id"] = groupId.ToString(),
                ["topic_id"] = topicId.ToString(),
                ["title"] = title
            };
            return await PostAsync<int>("editTopic", parameters, cancellationToken);
        }

        /// <summary>
        /// Pins a topic to the top of a community's board.
        /// </summary>
        /// <param name="groupId">The community ID.</param>
        /// <param name="topicId">The topic ID.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> FixTopicAsync(int groupId, int topicId, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["group_id"] = groupId.ToString(),
                ["topic_id"] = topicId.ToString()
            };
            return await PostAsync<int>("fixTopic", parameters, cancellationToken);
        }

        /// <summary>
        /// Returns a list of comments on a topic on a community's board.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="BoardCommentsList"/> object containing comments.</returns>
        public async Task<BoardCommentsList> GetCommentsAsync(BoardGetCommentsParams @params, CancellationToken cancellationToken = default)
        {
            return await GetAsync<BoardCommentsList>("getComments", @params, cancellationToken);
        }

        /// <summary>
        /// Returns a list of topics on a community's board.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="BoardTopics"/> object containing topics.</returns>
        public async Task<BoardTopics> GetTopicsAsync(BoardGetTopicsParams @params, CancellationToken cancellationToken = default)
        {
            return await GetAsync<BoardTopics>("getTopics", @params, cancellationToken);
        }

        /// <summary>
        /// Re-opens a previously closed topic.
        /// </summary>
        /// <param name="groupId">The community ID.</param>
        /// <param name="topicId">The topic ID.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> OpenTopicAsync(int groupId, int topicId, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["group_id"] = groupId.ToString(),
                ["topic_id"] = topicId.ToString()
            };
            return await PostAsync<int>("openTopic", parameters, cancellationToken);
        }

        /// <summary>
        /// Unpins a previously pinned topic.
        /// </summary>
        /// <param name="groupId">The community ID.</param>
        /// <param name="topicId">The topic ID.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> UnfixTopicAsync(int groupId, int topicId, CancellationToken cancellationToken = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["group_id"] = groupId.ToString(),
                ["topic_id"] = topicId.ToString()
            };
            return await PostAsync<int>("unfixTopic", parameters, cancellationToken);
        }
    }
}
