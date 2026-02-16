using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Photos;
using OpenVkNetApi.Models.RequestParameters.Photos;
using OpenVkNetApi.Utils;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;

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
        
        private async Task<UploadResult> UploadAsync(string uploadUrl, Stream photoStream, string fileName, CancellationToken ct)
        {
            using var form = new MultipartFormDataContent();
            using var streamContent = new StreamContent(photoStream);

            streamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(GetMimeType(fileName));
            form.Add(streamContent, "photo", fileName);

            var uploadResponse = await _api.HttpClient.PostAsync(uploadUrl, form, ct);

            if (!uploadResponse.IsSuccessStatusCode)
                throw new HttpRequestException($"Photo upload failed with status code {uploadResponse.StatusCode}");

            var json = await uploadResponse.Content.ReadAsStringAsync();
            var uploadData = JsonConvert.DeserializeObject<UploadResult>(json);

            if (uploadData == null || string.IsNullOrEmpty(uploadData.Hash) || (string.IsNullOrEmpty(uploadData.Photo) && string.IsNullOrEmpty(uploadData.PhotosList)))
                throw new OvkApiException(-1, "Failed to process upload response.");

            return uploadData;
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

            var uploadData = await UploadAsync(uploadServerInfo.UploadUrl!, photoStream, fileName, ct);

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

            var uploadData = await UploadAsync(uploadServerInfo.UploadUrl!, photoStream, fileName, ct);

            return await SaveOwnerPhotoAsync(uploadData.Photo!, uploadData.Hash, ct);
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
        public async Task<Collection<Photo>> UploadAlbumPhotoAsync(Stream photoStream, string fileName, int albumId, string? caption = null, CancellationToken ct = default)
        {
            if (string.IsNullOrEmpty(_api.AccessToken))
                throw new System.InvalidOperationException("API is not authorized. Call AuthorizeAsync() first.");
            
            var uploadServerInfo = await GetUploadServerAsync(albumId, ct);
            if (string.IsNullOrEmpty(uploadServerInfo.UploadUrl))
                throw new OvkApiException(-1, "Failed to get album upload URL.");

            var uploadData = await UploadAsync(uploadServerInfo.UploadUrl!, photoStream, fileName, ct);

            return await SaveAsync(new PhotosSaveParams
            {
                PhotosList = uploadData.PhotosList!,
                Hash = uploadData.Hash,
                AlbumId = albumId,
                Caption = caption
            }, ct);
        }

        /// <summary>
        /// Returns the server address for owner photo upload.
        /// </summary>
        /// <param name="ownerId">The user or group ID. Use a negative value for a group ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<PhotosOwnerPhotoUploadServer> GetOwnerPhotoUploadServerAsync(int? ownerId = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>();
            if (ownerId.HasValue)
            {
                parameters["owner_id"] = ownerId.Value.ToString();
            }
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
            var parameters = new Dictionary<string, string>
            {
                ["photo"] = photo,
                ["hash"] = hash
            };
            return await PostAsync<PhotosSaveOwnerPhoto>("saveOwnerPhoto", parameters, ct);
        }

        /// <summary>
        /// Returns the server address for wall photo upload.
        /// </summary>
        /// <param name="groupId">The group ID. If not specified, the current user's wall is used.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        public async Task<PhotosUploadServer> GetWallUploadServerAsync(int? groupId = null, CancellationToken ct = default)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId.HasValue)
            {
                parameters["group_id"] = groupId.Value.ToString();
            }
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
            var parameters = new Dictionary<string, string>();
            if (albumId.HasValue)
            {
                parameters["album_id"] = albumId.Value.ToString();
            }
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
            var parameters = new Dictionary<string, string>
            {
                ["title"] = title,
                ["group_id"] = groupId.ToString(),
                ["description"] = description
            };
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
            var parameters = new Dictionary<string, string>();
            if (userId.HasValue)
            {
                parameters["user_id"] = userId.Value.ToString();
            }
            if (groupId.HasValue)
            {
                parameters["group_id"] = groupId.Value.ToString();
            }
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
            var parameters = new Dictionary<string, string>
            {
                ["photos"] = photos,
                ["extended"] = extended ? "1" : "0",
                ["photo_sizes"] = photoSizes ? "1" : "0"
            };
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
            var parameters = new Dictionary<string, string>
            {
                ["album_id"] = albumId.ToString(),
                ["group_id"] = groupId.ToString()
            };
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
            var parameters = new Dictionary<string, string>
            {
                ["owner_id"] = ownerId.ToString(),
                ["photo_id"] = photoId.ToString(),
                ["caption"] = caption
            };
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
            var parameters = new Dictionary<string, string>();
            if (ownerId.HasValue)
            {
                parameters["owner_id"] = ownerId.Value.ToString();
            }
            if (photoId.HasValue)
            {
                parameters["photo_id"] = photoId.Value.ToString();
            }
            if (!string.IsNullOrEmpty(photos))
            {
                parameters["photos"] = photos!;
            }
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
        public async Task<PhotosComments> GetCommentsAsync(PhotosGetCommentsParams @params, CancellationToken ct = default)
        {
            return await GetAsync<PhotosComments>("getComments", @params, ct);
        }
    }
}