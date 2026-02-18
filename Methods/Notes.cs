using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Comments;
using OpenVkNetApi.Models.Notes;
using OpenVkNetApi.Models.RequestParameters.Notes;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with notes.
    /// Encapsulates the <c>notes.*</c> methods of the OpenVK API.
    /// </summary>
    public class Notes : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notes"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Notes(OpenVkApi api) : base(api, "notes") { }

        /// <summary>
        /// Creates a new note.
        /// </summary>
        /// <param name="title">The note title.</param>
        /// <param name="text">The note text.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The ID of the created note.</returns>
        public async Task<int> AddAsync(string title, string text, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["title"] = title,
                ["text"] = text
            };
            return await PostAsync<int>("add", parameters, ct);
        }
        
        /// <summary>
        /// Creates a new comment on a note.
        /// </summary>
        /// <param name="params">Parameters for the comment creation.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The ID of the created comment.</returns>
        public async Task<int> CreateCommentAsync(NotesCreateCommentParams @params, CancellationToken ct = default)
        {
            return await PostAsync<int>("createComment", @params, ct);
        }

        /// <summary>
        /// Edits a note.
        /// </summary>
        /// <param name="params">Parameters for the edit operation.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> EditAsync(NotesEditParams @params, CancellationToken ct = default)
        {
            return await PostAsync<int>("edit", @params, ct);
        }

        /// <summary>
        /// Returns a list of the user's notes.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Note}"/> of note objects.</returns>
        public async Task<Collection<Note>> GetAsync(NotesGetParams @params, CancellationToken ct = default)
        {
            return await GetAsync<Collection<Note>>("get", @params, ct);
        }

        /// <summary>
        /// Returns a note by its ID.
        /// </summary>
        /// <param name="noteId">The note ID.</param>
        /// <param name="ownerId">The note owner's ID.</param>
        /// <param name="needWiki">True to return the note's content as wiki-formatted.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Note"/> object.</returns>
        public async Task<Note> GetByIdAsync(int noteId, int ownerId, bool needWiki = false, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>
            {
                ["note_id"] = noteId.ToString(),
                ["owner_id"] = ownerId.ToString(),
                ["need_wiki"] = needWiki ? "1" : "0"
            };
            return await GetAsync<Note>("getById", parameters, ct);
        }

        /// <summary>
        /// Returns a list of comments on a note.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{NoteComment}"/> of comment objects.</returns>
        public async Task<Collection<NoteComment>> GetCommentsAsync(NotesGetCommentsParams @params, CancellationToken ct = default)
        {
            return await GetAsync<Collection<NoteComment>>("getComments", @params, ct);
        }
    }
}
