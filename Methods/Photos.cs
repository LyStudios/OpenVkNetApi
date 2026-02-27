using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Comments;
using OpenVkNetApi.Models.Photos;
using OpenVkNetApi.Models.RequestParameters.Photos;
using OpenVkNetApi.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with photos.
    /// </summary>
    public class Photos : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Photos"/> class.
        /// </summary>
        /// <param name="api">The API instance.</param>
        public Photos(OpenVkApi api) : base(api, "photos") { }

        /// <summary>
        /// Determines the MIME type of a file based on its extension.
        /// </summary>
        /// <param name="fileName">The file name including extension.</param>
        /// <returns>The corresponding MIME type string. Returns <c>application/octet-stream</c> if the type is unknown.</returns>
        private string GetMimeType(string fileName)
        {
            var extension = Path.GetExtension(fileName).ToLowerInvariant();
            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";
                case ".gif":
                    return "image/gif";
                case ".bmp":
                    return "image/bmp";
                default:
                    return "application/octet-stream";
            }
        }

        /// <summary>
        /// Uploads a photo stream to the specified upload server URL.
        /// </summary>
        /// <param name="uploadUrl">The upload server URL returned by the API.</param>
        /// <param name="photoStream">The stream containing the photo data.</param>
        /// <param name="fileName">The file name (used for MIME type detection).</param>
        /// <param name="isMultifileMode">
        /// Indicates whether the upload is performed in multifile mode 
        /// (used for album uploads where the field name differs).
        /// </param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>
        /// An <see cref="UploadResult"/> object containing raw upload data 
        /// (hash, photo, photos_list).
        /// </returns>
        /// <exception cref="HttpRequestException">Thrown if the upload request fails.</exception>
        /// <exception cref="OvkApiException">Thrown if the upload response is invalid.</exception>
        private async Task<UploadResult> UploadAsync(string uploadUrl, Stream photoStream, string fileName, bool isMultifileMode, CancellationToken ct)
        {
            using (var form = new MultipartFormDataContent())
            using (var streamContent = new StreamContent(photoStream))
            {
                // determine MIME
                streamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(GetMimeType(fileName));

                // Field name for multi-upload
                string fieldName = "photo";
                if (isMultifileMode)
                {
                    fieldName += "1";
                }

                form.Add(streamContent, fieldName, fileName);

                var uploadResponse = await _api.HttpClient.PostAsync(uploadUrl, form, ct);
                var json = await uploadResponse.Content.ReadAsStringAsync();
                if (!uploadResponse.IsSuccessStatusCode)
                    throw new HttpRequestException($"Photo upload failed with status code {uploadResponse.StatusCode}: {json}");

                var uploadData = JsonConvert.DeserializeObject<UploadResult>(json);

                if (uploadData == null || string.IsNullOrEmpty(uploadData.Hash) ||
                    (string.IsNullOrEmpty(uploadData.Photo) && string.IsNullOrEmpty(uploadData.PhotosList)))
                    throw new OvkApiException(-1, "Failed to process upload response.");

                return uploadData;
            }
        }

        /// <summary>
        /// Uploads a photo to a user's or group's wall.
        /// </summary>
        /// <param name="photoStream">A stream containing the photo data.</param>
        /// <param name="fileName">The name of the file (e.g., "image.jpg").</param>
        /// <param name="groupId">The ID of the group to upload the photo to. If null, uploads to the current user's wall.</param>
        /// <param name="caption">The caption for the photo.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A list of the uploaded <see cref="Photo"/> objects.</returns>
        public async Task<List<Photo>> UploadWallPhotoAsync(Stream photoStream, string fileName, int? groupId = null, string? caption = null, CancellationToken ct = default)
        {
            if (string.IsNullOrEmpty(_api.AccessToken))
                throw new System.InvalidOperationException("API is not authorized. Call AuthorizeAsync() first.");

            var uploadServerInfo = await GetWallUploadServerAsync(groupId, ct);

            if (string.IsNullOrEmpty(uploadServerInfo.UploadUrl))
                throw new OvkApiException(-1, "Failed to get wall upload URL.");

            var uploadData = await UploadAsync(uploadServerInfo.UploadUrl!, photoStream, fileName, false, ct);

            return await SaveWallPhotoAsync(new PhotosSaveWallPhotoParams
            {
                Photo = uploadData.Photo!,
                Hash = uploadData.Hash,
                GroupId = groupId ?? 0,
                Caption = caption
            }, ct);
        }
        
        /// <summary>
        /// Uploads a new profile or group avatar.
        /// </summary>
        /// <param name="photoStream">A stream containing the photo data.</param>
        /// <param name="fileName">The name of the file (e.g., "image.jpg").</param>
        /// <param name="ownerId">The user or group ID. Use a negative value for a group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="PhotosSaveOwnerPhoto"/> object with the result.</returns>
        public async Task<PhotosSaveOwnerPhoto> UploadOwnerPhotoAsync(Stream photoStream, string fileName, int? ownerId = null, CancellationToken ct = default)
        {
            if (string.IsNullOrEmpty(_api.AccessToken))
                throw new System.InvalidOperationException("API is not authorized. Call AuthorizeAsync() first.");

            var uploadServerInfo = await GetOwnerPhotoUploadServerAsync(ownerId, ct);
            if (string.IsNullOrEmpty(uploadServerInfo.UploadUrl))
                throw new OvkApiException(-1, "Failed to get owner photo upload URL.");

            var uploadData = await UploadAsync(uploadServerInfo.UploadUrl!, photoStream, fileName, false, ct);

            return await SaveOwnerPhotoAsync(uploadData.Photo!, uploadData.Hash, ct);
        }

        /// <summary>
        /// Uploads a photo intended to be attached to a private message.
        /// </summary>
        /// <param name="stream">A stream containing the photo data.</param>
        /// <param name="fileName">The file name (e.g., "image.jpg").</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>
        /// A <see cref="Collection{Photo}"/> containing uploaded photo objects
        /// ready to be attached to a message.
        /// </returns>
        internal async Task<Collection<Photo>> UploadMessagePhotoAsync(Stream stream, string fileName, CancellationToken ct = default)
        {
            var result = await UploadAlbumPhotoAsync(
                stream,
                fileName,
                albumId: 0,
                caption: null,
                ct);

            return result;
        }


        /// <summary>
        /// Uploads a photo to a specific album.
        /// </summary>
        /// <param name="photoStream">A stream containing the photo data.</param>
        /// <param name="fileName">The name of the file (e.g., "image.jpg").</param>
        /// <param name="albumId">The ID of the album to upload the photo to.</param>
        /// <param name="caption">The caption for the photo.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A collection of the uploaded <see cref="Photo"/> objects.</returns>
        public async Task<Collection<Photo>> UploadAlbumPhotoAsync(Stream photoStream, string fileName, int? albumId, string? caption = null, CancellationToken ct = default)
        {
            if (string.IsNullOrEmpty(_api.AccessToken))
                throw new System.InvalidOperationException("API is not authorized. Call AuthorizeAsync() first.");
            
            var uploadServerInfo = await GetUploadServerAsync(albumId, ct);
            if (string.IsNullOrEmpty(uploadServerInfo.UploadUrl))
                throw new OvkApiException(-1, "Failed to get album upload URL.");

            var uploadData = await UploadAsync(uploadServerInfo.UploadUrl!, photoStream, fileName, true, ct);

            return await SaveAsync(new PhotosSaveParams
            {
                PhotosList = uploadData.PhotosList!,
                Hash = uploadData.Hash,
                AlbumId = albumId,
                Caption = caption
            }, ct);
        }

        /// <summary>
        /// Uploads multiple photos to a specific album.
        /// </summary>
        /// <param name="photos">A collection of tuples (Stream, fileName) representing photos to upload.</param>
        /// <param name="albumId">The album ID to upload the photos to.</param>
        /// <param name="caption">Optional caption for the photos.</param>
        /// <param name="ct">Cancellation token.</param>
        /// <returns>A collection of uploaded <see cref="Photo"/> objects.</returns>
        public async Task<Collection<Photo>> UploadAlbumPhotosAsync(IEnumerable<Tuple<Stream, string>> photos, int? albumId, string? caption = null, CancellationToken ct = default)
        {
            if (string.IsNullOrEmpty(_api.AccessToken))
                throw new InvalidOperationException("API is not authorized. Call AuthorizeAsync() first.");

            var uploadServerInfo = await GetUploadServerAsync(albumId, ct);
            if (string.IsNullOrEmpty(uploadServerInfo.UploadUrl))
                throw new OvkApiException(-1, "Failed to get album upload URL.");

            using (var form = new MultipartFormDataContent())
            {
                int index = 1;
                foreach (var photo in photos)
                {
                    var stream = photo.Item1;
                    var fileName = photo.Item2;

                    var streamContent = new StreamContent(stream);
                    streamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(GetMimeType(fileName));

                    form.Add(streamContent, "file" + index, fileName); // file1, file2, file3...
                    index++;
                }

                var uploadResponse = await _api.HttpClient.PostAsync(uploadServerInfo.UploadUrl, form, ct);
                var json = await uploadResponse.Content.ReadAsStringAsync();
                if (!uploadResponse.IsSuccessStatusCode)
                    throw new HttpRequestException($"Photo upload failed with status code {uploadResponse.StatusCode}: {json}");

                var uploadData = JsonConvert.DeserializeObject<UploadResult>(json);
                if (uploadData == null || string.IsNullOrEmpty(uploadData.Hash) || string.IsNullOrEmpty(uploadData.PhotosList))
                    throw new OvkApiException(-1, "Failed to process upload response.");

                return await SaveAsync(new PhotosSaveParams
                {
                    PhotosList = uploadData.PhotosList!,
                    Hash = uploadData.Hash,
                    AlbumId = albumId,
                    Caption = caption
                }, ct);
            }
        }

        /// <summary>
        /// Returns the server address for owner photo upload.
        /// </summary>
        /// <param name="ownerId">The user or group ID. Use a negative value for a group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<PhotosOwnerPhotoUploadServer> GetOwnerPhotoUploadServerAsync(int? ownerId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .ToDictionary();

            return await GetAsync<PhotosOwnerPhotoUploadServer>("getOwnerPhotoUploadServer", parameters, ct);
        }

        /// <summary>
        /// Saves a photo after being successfully uploaded to an upload server.
        /// </summary>
        /// <param name="photo">The 'photo' parameter returned by the upload server.</param>
        /// <param name="hash">The 'hash' parameter returned by the upload server.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<PhotosSaveOwnerPhoto> SaveOwnerPhotoAsync(string photo, string hash, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("photo", photo)
                .Add("hash", hash)
                .ToDictionary();

            return await PostAsync<PhotosSaveOwnerPhoto>("saveOwnerPhoto", parameters, ct);
        }

        /// <summary>
        /// Returns the server address for wall photo upload.
        /// </summary>
        /// <param name="groupId">The group ID. If not specified, the current user's wall is used.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<PhotosUploadServer> GetWallUploadServerAsync(int? groupId = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("group_id", groupId)
                .ToDictionary();

            return await GetAsync<PhotosUploadServer>("getWallUploadServer", parameters, ct);
        }

        /// <summary>
        /// Saves a photo to a user's or group's wall after being successfully uploaded.
        /// </summary>
        /// <param name="params">The request parameters, including photo data and hash.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<List<Photo>> SaveWallPhotoAsync(PhotosSaveWallPhotoParams @params, CancellationToken ct = default)
        {
            return await PostAsync<List<Photo>>("saveWallPhoto", @params, ct);
        }

        /// <summary>
        /// Returns the server address for photo upload into an album.
        /// </summary>
        /// <param name="albumId">The album ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<PhotosUploadServer> GetUploadServerAsync(int? albumId = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("album_id", albumId)
                .ToDictionary();

            return await GetAsync<PhotosUploadServer>("getUploadServer", parameters, ct);
        }
        
        /// <summary>
        /// Saves photos after successful upload.
        /// </summary>
        /// <param name="params">The request parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<Collection<Photo>> SaveAsync(PhotosSaveParams @params, CancellationToken ct = default)
        {
            return await PostAsync<Collection<Photo>>("save", @params, ct);
        }

        /// <summary>
        /// Creates an empty photo album.
        /// </summary>
        /// <param name="title">The album title.</param>
        /// <param name="groupId">The group ID, if creating an album in a group.</param>
        /// <param name="description">The album description.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<Album> CreateAlbumAsync(string title, int groupId = 0, string description = "", CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("title", title)
                .Add("group_id", groupId)
                .Add("description", description)
                .ToDictionary();

            return await PostAsync<Album>("createAlbum", parameters, ct);
        }
        
        /// <summary>
        /// Edits a photo album.
        /// </summary>
        /// <param name="params">The request parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<int> EditAlbumAsync(PhotosEditAlbumParams @params, CancellationToken ct = default)
        {
            return await PostAsync<int>("editAlbum", @params, ct);
        }

        /// <summary>
        /// Returns a list of photo albums.
        /// </summary>
        /// <param name="params">The request parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<Collection<Album>> GetAlbumsAsync(PhotosGetAlbumsParams @params, CancellationToken ct = default)
        {
            return await GetAsync<Collection<Album>>("getAlbums", @params, ct);
        }

        /// <summary>
        /// Returns the number of photo albums.
        /// </summary>
        /// <param name="userId">The user ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<int> GetAlbumsCountAsync(int? userId = null, int? groupId = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("user_id", userId)
                .Add("group_id", groupId)
                .ToDictionary();

            return await GetAsync<int>("getAlbumsCount", parameters, ct);
        }

        /// <summary>
        /// Returns photo information by its ID.
        /// </summary>
        /// <param name="photos">A comma-separated list of photo IDs.</param>
        /// <param name="extended">Specifies if extended information should be returned.</param>
        /// <param name="photoSizes">Specifies if photo size information should be returned.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<List<Photo>> GetByIdAsync(string photos, bool extended = false, bool photoSizes = false, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("photos", photos)
                .Add("extended", extended)
                .Add("photo_sizes", photoSizes)
                .ToDictionary();

            return await GetAsync<List<Photo>>("getById", parameters, ct);
        }

        /// <summary>
        /// Returns a list of photos.
        /// </summary>
        /// <param name="params">The request parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<Collection<Photo>> GetAsync(PhotosGetParams @params, CancellationToken ct = default)
        {
            return await GetAsync<Collection<Photo>>("get", @params, ct);
        }

        /// <summary>
        /// Deletes a photo album.
        /// </summary>
        /// <param name="albumId">The album ID.</param>
        /// <param name="groupId">The group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<int> DeleteAlbumAsync(int albumId, int groupId = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("album_id", albumId)
                .Add("group_id", groupId)
                .ToDictionary();

            return await PostAsync<int>("deleteAlbum", parameters, ct);
        }

        /// <summary>
        /// Edits a photo's caption.
        /// </summary>
        /// <param name="ownerId">The photo owner's ID.</param>
        /// <param name="photoId">The photo ID.</param>
        /// <param name="caption">The new caption.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<int> EditAsync(int ownerId, int photoId, string caption = "", CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("photo_id", photoId)
                .Add("caption", caption)
                .ToDictionary();

            return await PostAsync<int>("edit", parameters, ct);
        }

        /// <summary>
        /// Deletes one or more photos.
        /// </summary>
        /// <param name="ownerId">The owner ID.</param>
        /// <param name="photoId">The photo ID (if deleting a single photo).</param>
        /// <param name="photos">A comma-separated list of photo IDs (if deleting multiple photos).</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<int> DeleteAsync(int? ownerId = null, int? photoId = null, string? photos = null, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("photo_id", photoId)
                .Add("photos", photos)
                .ToDictionary();

            return await PostAsync<int>("delete", parameters, ct);
        }

        /// <summary>
        /// Creates a new comment on a photo.
        /// </summary>
        /// <param name="params">The request parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<int> CreateCommentAsync(PhotosCreateCommentParams @params, CancellationToken ct = default)
        {
            return await PostAsync<int>("createComment", @params, ct);
        }

        /// <summary>
        /// Returns all of a user's photos.
        /// </summary>
        /// <param name="params">The request parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<Collection<Photo>> GetAllAsync(PhotosGetAllParams @params, CancellationToken ct = default)
        {
            return await GetAsync<Collection<Photo>>("getAll", @params, ct);
        }

        /// <summary>
        /// Returns a list of comments on a photo.
        /// </summary>
        /// <param name="params">The request parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<ExtendedCollection<PhotoComment>> GetCommentsAsync(PhotosGetCommentsParams @params, CancellationToken ct = default)
        {
            return await GetAsync<ExtendedCollection<PhotoComment>>("getComments", @params, ct);
        }
    }
}
