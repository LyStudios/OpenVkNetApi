using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models.RequestParameters.Wall;
using OpenVkNetApi.Models.Wall;
using OpenVkNetApi.Utils;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with wall posts.
    /// Encapsulates the <c>wall.*</c> methods of the OpenVK API.
    /// </summary>
    public class Wall : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wall"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Wall(OpenVkApi api) : base(api, "wall") { }

        /// <summary>
        /// Returns a list of posts from a user's or community's wall.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="WallGet"/> object containing wall posts.</returns>
        public async Task<WallGet> GetAsync(WallGetParams @params, CancellationToken ct = default)
        {
            return await GetAsync<WallGet>("get", @params, ct);
        }

        /// <summary>
        /// Returns a list of wall posts by their IDs.
        /// </summary>
        /// <param name="posts">A comma-separated list of post IDs in the format 'owner_id_post_id'.</param>
        /// <param name="extended">True to return extended information.</param>
        /// <param name="fields">A list of additional profile fields to return.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="WallGetById"/> object containing the requested posts.</returns>
        public async Task<WallGetById> GetByIdAsync(string posts, bool extended = false, UserFields fields = UserFields.None, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("posts", posts)
                .Add("extended", extended ? 1 : 0)
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .ToDictionary();

            return await GetAsync<WallGetById>("getById", parameters, ct);
        }

        /// <summary>
        /// Creates a new post on a wall.
        /// </summary>
        /// <param name="params">Parameters for the post.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="WallPostId"/> object with the ID of the created post.</returns>
        public async Task<WallPostId> PostAsync(WallPostParams @params, CancellationToken ct = default)
        {
            return await PostAsync<WallPostId>("post", @params, ct);
        }

        /// <summary>
        /// Reposts an object to a user's or community's wall.
        /// </summary>
        /// <param name="params">Parameters for the repost.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="WallRepost"/> object with the result.</returns>
        public async Task<WallRepost> RepostAsync(WallRepostParams @params, CancellationToken ct = default)
        {
            return await PostAsync<WallRepost>("repost", @params, ct);
        }

        /// <summary>
        /// Returns a list of comments on a wall post.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="WallGetComments"/> object containing comments.</returns>
        public async Task<WallGetComments> GetCommentsAsync(WallGetCommentsParams @params, CancellationToken ct = default)
        {
            return await GetAsync<WallGetComments>("getComments", @params, ct);
        }

        /// <summary>
        /// Returns a single comment on a wall post.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="WallGetComment"/> object.</returns>
        public async Task<WallGetComment> GetCommentAsync(WallGetCommentParams @params, CancellationToken ct = default)
        {
            return await GetAsync<WallGetComment>("getComment", @params, ct);
        }

        /// <summary>
        /// Creates a new comment on a wall post.
        /// </summary>
        /// <param name="params">Parameters for the comment creation.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="WallCreateComment"/> object with the ID of the created comment.</returns>
        public async Task<WallCreateComment> CreateCommentAsync(WallCreateCommentParams @params, CancellationToken ct = default)
        {
            return await PostAsync<WallCreateComment>("createComment", @params, ct);
        }

        /// <summary>
        /// Deletes a comment on a wall post.
        /// </summary>
        /// <param name="commentId">The comment ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> DeleteCommentAsync(int commentId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("comment_id", commentId)
                .ToDictionary();

            return await PostAsync<int>("deleteComment", parameters, ct);
        }

        /// <summary>
        /// Deletes a wall post.
        /// </summary>
        /// <param name="ownerId">The wall owner's ID.</param>
        /// <param name="postId">The post ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> DeleteAsync(int ownerId, int postId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("post_id", postId)
                .ToDictionary();

            return await PostAsync<int>("delete", parameters, ct);
        }

        /// <summary>
        /// Edits a wall post.
        /// </summary>
        /// <param name="params">Parameters for the edit operation.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="WallEdit"/> object with the result.</returns>
        public async Task<WallEdit> EditAsync(WallEditParams @params, CancellationToken ct = default)
        {
            return await PostAsync<WallEdit>("edit", @params, ct);
        }

        /// <summary>
        /// Edits a comment on a wall post.
        /// </summary>
        /// <param name="params">Parameters for the edit operation.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> EditCommentAsync(WallEditCommentParams @params, CancellationToken ct = default)
        {
            return await PostAsync<int>("editComment", @params, ct);
        }

        /// <summary>
        /// Checks a link for potential copyright restrictions.
        /// </summary>
        /// <param name="link"> The URL to be checked. </param>
        /// <param name="ct"> A <see cref="CancellationToken"/> that can be used to cancel the request. </param>
        /// <returns> An integer representing the API's result code. Typically returns <c>1</c> if the link passes the check.
        /// </returns>
        public async Task<int> CheckCopyrightLinkAsync(string link, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("link", link)
                .ToDictionary();

            return await GetAsync<int>("checkCopyrightLink", parameters, ct);
        }

        /// <summary>
        /// Pins a post to the top of a wall.
        /// </summary>
        /// <param name="ownerId">The wall owner's ID.</param>
        /// <param name="postId">The post ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> PinAsync(int ownerId, int postId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("post_id", postId)
                .ToDictionary();

            return await PostAsync<int>("pin", parameters, ct);
        }

        /// <summary>
        /// Unpins a post from a wall.
        /// </summary>
        /// <param name="ownerId">The wall owner's ID.</param>
        /// <param name="postId">The post ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> UnpinAsync(int ownerId, int postId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("post_id", postId)
                .ToDictionary();

            return await PostAsync<int>("unpin", parameters, ct);
        }
    }
}
