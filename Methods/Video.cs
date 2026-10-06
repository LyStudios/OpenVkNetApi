using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Comments;
using OpenVkNetApi.Models.RequestParameters.Video;
using OpenVkNetApi.Models.Video;
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
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="ExtendedCollection{Video}"/> of video objects.</returns>
        public async Task<ExtendedCollection<Models.Video.Video>> GetAsync(VideoGetParams @params, CancellationToken ct = default)
        {
            return await GetAsync<ExtendedCollection<Models.Video.Video>>("get", @params, ct);
        }

        /// <summary>
        /// Searches for videos.
        /// </summary>
        /// <param name="params">Search parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="ExtendedCollection{Video}"/> of found video objects.</returns>
        public async Task<ExtendedCollection<Models.Video.Video>> SearchAsync(VideoSearchParams @params, CancellationToken ct = default)
        {
            return await GetAsync<ExtendedCollection<Models.Video.Video>>("search", @params, ct);
        }

        /// <summary>
        /// Returns a list of videos belonging to a user or community.
        /// </summary>
        /// <param name="userId">Target user or community ID (negative for community).</param>
        /// <param name="offset">Offset for pagination.</param>
        /// <param name="count">Number of videos to return.</param>
        /// <param name="extended">Whether to return extended user and group profiles.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="ExtendedCollection{Video}"/> of videos.</returns>
        public async Task<ExtendedCollection<Models.Video.Video>> GetUserVideosAsync(int userId = 0, int offset = 0, int count = 30, bool extended = false, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("user_id", userId)
                .Add("offset", offset)
                .Add("count", count)
                .Add("extended", extended ? 1 : 0)
                .ToDictionary();

            return await GetAsync<ExtendedCollection<Models.Video.Video>>("getUserVideos", parameters, ct);
        }

        /// <summary>
        /// Edits the information of a video.
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="videoId">Video ID.</param>
        /// <param name="name">New video title.</param>
        /// <param name="desc">New video description.</param>
        /// <param name="noComments">Whether to disable comments.</param>
        /// <param name="repeat">Whether to repeat the video automatically.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A boolean indicating whether the edit was successful.</returns>
        public async Task<bool> EditAsync(int ownerId, int videoId, string name = null, string desc = null, bool noComments = false, bool repeat = false, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("video_id", videoId)
                .Add("name", name)
                .Add("desc", desc)
                .Add("no_comments", noComments ? 1 : 0)
                .Add("repeat", repeat ? 1 : 0)
                .ToDictionary();

            var result = await PostAsync<VideoEditResult>("edit", parameters, ct);
            return result?.Success == 1;
        }

        /// <summary>
        /// Deletes a video from the site.
        /// </summary>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="videoId">Video ID.</param>
        /// <param name="targetId">Target community/user ID (optional).</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A boolean indicating success.</returns>
        public async Task<bool> DeleteAsync(int ownerId, int videoId, int? targetId = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("video_id", videoId)
                .Add("target_id", targetId)
                .ToDictionary();

            var result = await PostAsync<int>("delete", parameters, ct);
            return result == 1;
        }

        /// <summary>
        /// Returns a list of comments on a video.
        /// </summary>
        /// <param name="videoId">Video ID.</param>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="needLikes">Whether to return like information.</param>
        /// <param name="offset">Offset for pagination.</param>
        /// <param name="count">Number of comments to return.</param>
        /// <param name="sort">Sort order ("asc" or "desc").</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{VideoComment}"/> of video comments.</returns>
        public async Task<Collection<VideoComment>> GetCommentsAsync(int videoId, int ownerId = 0, bool needLikes = false, int offset = 0, int count = 20, string sort = "asc", CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("video_id", videoId)
                .Add("owner_id", ownerId)
                .Add("need_likes", needLikes ? 1 : 0)
                .Add("offset", offset)
                .Add("count", count)
                .Add("sort", sort)
                .ToDictionary();

            return await GetAsync<Collection<VideoComment>>("getComments", parameters, ct);
        }

        /// <summary>
        /// Adds a new comment on a video.
        /// </summary>
        /// <param name="videoId">Video ID.</param>
        /// <param name="ownerId">ID of the user or community that owns the video.</param>
        /// <param name="message">Message text.</param>
        /// <param name="text">Alternative parameter for message text.</param>
        /// <param name="replyToCid">ID of the comment being replied to.</param>
        /// <param name="replyToComment">Alternative parameter for reply target ID.</param>
        /// <param name="stickerId">Sticker ID if posting a sticker.</param>
        /// <param name="attachments">Comma-separated list of attachments.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The ID of the newly created comment.</returns>
        public async Task<int> CreateCommentAsync(int videoId, int ownerId = 0, string message = "", string text = "", int replyToCid = 0, int replyToComment = 0, int stickerId = 0, string attachments = "", CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("video_id", videoId)
                .Add("owner_id", ownerId)
                .Add("message", message)
                .Add("text", text)
                .Add("reply_to_cid", replyToCid)
                .Add("reply_to_comment", replyToComment)
                .Add("sticker_id", stickerId)
                .Add("attachments", attachments)
                .ToDictionary();

            var result = await PostAsync<VideoCreateCommentResult>("createComment", parameters, ct);
            return result.CommentId != 0 ? result.CommentId : result.Cid;
        }

        /// <summary>
        /// Adds a new comment on a video (alias to <see cref="CreateCommentAsync"/>).
        /// </summary>
        public Task<int> AddCommentAsync(int videoId, int ownerId = 0, string message = "", string text = "", int replyToCid = 0, int replyToComment = 0, int stickerId = 0, string attachments = "", CancellationToken ct = default)
        {
            return CreateCommentAsync(videoId, ownerId, message, text, replyToCid, replyToComment, stickerId, attachments, ct);
        }

        /// <summary>
        /// Deletes a comment on a video.
        /// </summary>
        /// <param name="commentId">Comment ID to delete.</param>
        /// <param name="videoId">Video ID.</param>
        /// <param name="cid">Alternative comment ID parameter.</param>
        /// <param name="ownerId">Owner ID of the video.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A boolean indicating success.</returns>
        public async Task<bool> DeleteCommentAsync(int commentId = 0, int videoId = 0, int cid = 0, int ownerId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("comment_id", commentId)
                .Add("video_id", videoId)
                .Add("cid", cid)
                .Add("owner_id", ownerId)
                .ToDictionary();

            var result = await PostAsync<int>("deleteComment", parameters, ct);
            return result == 1;
        }
    }
}
