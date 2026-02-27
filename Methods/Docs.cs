using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Docs;
using OpenVkNetApi.Models.RequestParameters.Docs;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with documents.
    /// Encapsulates the <c>docs.*</c> methods of the OpenVK API.
    /// </summary>
    public class Docs : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Docs"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Docs(OpenVkApi api) : base(api, "docs") { }

        /// <summary>
        /// Adds a document to a user's or community's collection.
        /// </summary>
        /// <param name="ownerId">The owner ID of the document.</param>
        /// <param name="docId">The document ID.</param>
        /// <param name="accessKey">The access key for the document.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The ID of the added document.</returns>
        public async Task<string> AddAsync(int ownerId, int docId, string? accessKey = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("doc_id", docId)
                .Add("access_key", accessKey)
                .ToDictionary();

            return await PostAsync<string>("add", parameters, ct);
        }
        
        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="ownerId">The owner ID of the document.</param>
        /// <param name="docId">The document ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> DeleteAsync(int ownerId, int docId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("doc_id", docId)
                .ToDictionary();

            return await PostAsync<int>("delete", parameters, ct);
        }

        /// <summary>
        /// Restores a deleted document.
        /// </summary>
        /// <param name="ownerId">The owner ID of the document.</param>
        /// <param name="docId">The document ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> RestoreAsync(int ownerId, int docId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("doc_id", docId)
                .ToDictionary();

            return await PostAsync<int>("restore", parameters, ct);
        }

        /// <summary>
        /// Edits a document.
        /// </summary>
        /// <param name="params">Parameters for the edit operation.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> EditAsync(DocsEditParams @params, CancellationToken ct = default)
        {
            return await PostAsync<int>("edit", @params, ct);
        }

        /// <summary>
        /// Returns a list of documents.
        /// </summary>
        /// <param name="params">Parameters for the request.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Doc}"/> of documents.</returns>
        public async Task<Collection<Doc>> GetAsync(DocsGetParams @params, CancellationToken ct = default)
        {
            return await GetAsync<Collection<Doc>>("get", @params, ct);
        }

        /// <summary>
        /// Returns information about documents by their IDs.
        /// </summary>
        /// <param name="docs">A comma-separated list of document IDs in the format 'owner_id_doc_id'.</param>
        /// <param name="returnTags">Whether to return document tags.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="Doc"/> objects.</returns>
        public async Task<List<Doc>> GetByIdAsync(string docs, bool returnTags = false, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("docs", docs)
                .Add("return_tags", returnTags ? 1 : 0)
                .ToDictionary();

            return await GetAsync<List<Doc>>("getById", parameters, ct);
        }

        /// <summary>
        /// Returns the available document types for a user.
        /// </summary>
        /// <param name="ownerId">The owner ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{DocType}"/> of document types.</returns>
        public async Task<Collection<DocType>> GetTypesAsync(int? ownerId = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .ToDictionary();

            return await GetAsync<Collection<DocType>>("getTypes", parameters, ct);
        }

        /// <summary>
        /// Retrieves the list of tags for documents of a user.
        /// </summary>
        /// <param name="ownerId"> The ID of the document owner. If <c>null</c>, defaults to the current authorized user. </param>
        /// <param name="type"> The type of documents to filter by. If <c>null</c>, defaults to 0 (all types). </param>
        /// <param name="ct"> A <see cref="CancellationToken"/> that can be used to cancel the request. </param>
        /// <returns> A <see cref="List{String}"/> containing the document tags. </returns>
        public async Task<List<string>> GetTagsAsync(int? ownerId = null, int? type = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("type", type)
                .ToDictionary();

            return await GetAsync<List<string>>("getTags", parameters, ct);
        }

        /// <summary>
        /// Searches for documents.
        /// </summary>
        /// <param name="params">Search parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Doc}"/> of found documents.</returns>
        public async Task<Collection<Doc>> SearchAsync(DocsSearchParams @params, CancellationToken ct = default)
        {
            return await GetAsync<Collection<Doc>>("search", @params, ct);
        }

        /// <summary>
        /// Returns the server address for document upload.
        /// </summary>
        /// <param name="groupId">The group ID (if uploading to a group).</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the upload server URL.</returns>
        public async Task<int> GetUploadServerAsync(int? groupId = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .ToDictionary();

            return await GetAsync<int>("getUploadServer", parameters, ct);
        }

        /// <summary>
        /// Returns the server address for wall document upload.
        /// </summary>
        /// <param name="groupId">The group ID (if uploading to a group's wall).</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the upload server URL.</returns>
        public async Task<int> GetWallUploadServerAsync(int? groupId = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .ToDictionary();

            return await GetAsync<int>("getWallUploadServer", parameters, ct);
        }

        /// <summary>
        /// Saves a document after successful upload.
        /// </summary>
        /// <param name="params">Parameters for the save operation.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code.</returns>
        public async Task<int> SaveAsync(DocsSaveParams @params, CancellationToken ct = default)
        {
            return await PostAsync<int>("save", @params, ct);
        }
    }
}
