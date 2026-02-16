using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Audio;
using OpenVkNetApi.Models.RequestParameters.Audio;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with audio files.
    /// Encapsulates the <c>audio.*</c> methods of the OpenVK API.
    /// </summary>
    public class Audio : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Audio"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        internal Audio(OpenVkApi api) : base(api, "audio") { }

        /// <summary>
        /// Returns information about audio files by their IDs.
        /// </summary>
        /// <param name="audios">A comma-separated list of audio IDs in the format <c>owner_id_audio_id</c>.</param>
        /// <param name="hash">A specific hash value.</param>
        /// <param name="needUser">Whether to return information about the users who uploaded the audio.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Audio}"/> of audio objects.</returns>
        public async Task<Collection<Models.Audio.Audio>> GetByIdAsync(string audios, string? hash = null, int needUser = 0,
            CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("audios", audios)
                .Add("hash", hash)
                .Add("need_user", needUser)
                .ToDictionary();

            return await GetAsync<Collection<Models.Audio.Audio>>("getById", parameters, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Checks if an audio file is the "Lagtrain" track.
        /// </summary>
        /// <param name="audioId">The audio ID in the format <c>owner_id_audio_id</c>.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns><c>1</c> if the audio is Lagtrain, otherwise <c>0</c>.</returns>
        public async Task<int> IsLagtrainAsync(string audioId, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("audio_id", audioId)
                .ToDictionary();

            return await GetAsync<int>("isLagtrain", parameters, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets a list of recommended audio files.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Audio}"/> of recommended audio objects.</returns>
        /// <remarks>May return an empty list if not implemented on the server.</remarks>
        public async Task<Collection<Models.Audio.Audio>> GetRecommendationsAsync(CancellationToken cancellationToken = default)
        {
            return await GetAsync<Collection<Models.Audio.Audio>>("getRecommendations", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets the total number of audio files for a user or group.
        /// </summary>
        /// <param name="ownerId">The owner's ID.</param>
        /// <param name="uploadedOnly">Whether to count only uploaded files (1) or all files (0).</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>The total number of audio files.</returns>
        public async Task<int> GetCountAsync(int ownerId, int uploadedOnly = 0, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("owner_id", ownerId)
                .Add("uploaded_only", uploadedOnly)
                .ToDictionary();

            return await GetAsync<int>("getCount", parameters, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets the lyrics for a specific audio file.
        /// </summary>
        /// <param name="lyricsId">The lyrics ID.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An <see cref="AudioLyrics"/> object containing the lyrics.</returns>
        public async Task<AudioLyrics> GetLyricsAsync(int lyricsId, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams().Add("lyrics_id", lyricsId).ToDictionary();
            return await GetAsync<AudioLyrics>("getLyrics", parameters, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// Gets a list of popular audio files.
        /// </summary>
        /// <param name="getPopularParams">Parameters for the request.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Audio}"/> of popular audio objects.</returns>
        public async Task<Collection<Models.Audio.Audio>> GetPopularAsync(AudioListRequestParams getPopularParams,
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<Collection<Models.Audio.Audio>>("getPopular", getPopularParams, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// Searches for audio files.
        /// </summary>
        /// <param name="searchParams">Search parameters.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Audio}"/> of found audio objects.</returns>
        public async Task<Collection<Models.Audio.Audio>> SearchAsync(AudioSearchParams searchParams,
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<Collection<Models.Audio.Audio>>("search", searchParams, cancellationToken: cancellationToken);
        }
        
        /// <summary>
        /// Gets a list of a user's or community's audio files.
        /// </summary>
        /// <param name="getParams">Parameters for the request.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An <see cref="AudioCollectionWithShuffle{Audio}"/> containing the audio files.</returns>
        public async Task<AudioCollectionWithShuffle<Models.Audio.Audio>> GetAsync(AudioGetParams getParams, CancellationToken cancellationToken = default)
        {
            return await GetAsync<AudioCollectionWithShuffle<Models.Audio.Audio>>("get", getParams, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Edits an audio file.
        /// </summary>
        /// <param name="editParams">Parameters for the edit operation.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> EditAsync(AudioEditParams editParams, CancellationToken cancellationToken = default)
        {
            return await GetAsync<int>("edit", editParams, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Adds an audio file to a user's or group's collection.
        /// </summary>
        /// <param name="addParams">Parameters for the add operation.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>The ID of the added audio file.</returns>
        public async Task<string> AddAsync(AudioAddParams addParams, CancellationToken cancellationToken = default)
        {
            return await GetAsync<string>("add", addParams, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Deletes an audio file.
        /// </summary>
        /// <param name="audioId">The ID of the audio file to delete.</param>
        /// <param name="ownerId">The ID of the audio file's owner.</param>
        /// <param name="groupId">The ID of the group (if deleting from a group).</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> DeleteAsync(int audioId, int ownerId, int? groupId = null,
            CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("audio_id", audioId)
                .Add("owner_id", ownerId)
                .Add("group_id", groupId)
                .ToDictionary();

            return await GetAsync<int>("delete", parameters, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Restores a deleted audio file.
        /// </summary>
        /// <param name="restoreParams">Parameters for the restore operation.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Audio}"/> containing the restored audio file.</returns>
        public async Task<Collection<Models.Audio.Audio>> RestoreAsync(AudioRestoreParams restoreParams,
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<Collection<Models.Audio.Audio>>("restore", restoreParams, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets a list of audio albums for a user or community.
        /// </summary>
        /// <param name="getAlbumsParams">Parameters for the request.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Album}"/> of audio albums.</returns>
        public async Task<Collection<Album>> GetAlbumsAsync(AudioGetAlbumsParams getAlbumsParams,
            CancellationToken cancellationToken = default)
        {
            return await GetAsync<Collection<Album>>("getAlbums", getAlbumsParams, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Adds a new audio album.
        /// </summary>
        /// <param name="title">The album title.</param>
        /// <param name="description">The album description (optional).</param>
        /// <param name="groupId">The group ID, if creating for a group.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>The ID of the created album.</returns>
        public async Task<int> AddAlbumAsync(string title, string? description = null, int groupId = 0,
            CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("title", title)
                .Add("description", description)
                .Add("group_id", groupId)
                .ToDictionary();

            return await GetAsync<int>("addAlbum", parameters, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Edits an audio album.
        /// </summary>
        /// <param name="albumId">The ID of the album to edit.</param>
        /// <param name="title">The new album title (optional).</param>
        /// <param name="description">The new album description (optional).</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> EditAlbumAsync(int albumId, string? title = null, string? description = null,
            CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("album_id", albumId)
                .Add("title", title)
                .Add("description", description)
                .ToDictionary();

            return await GetAsync<int>("editAlbum", parameters, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Deletes an audio album.
        /// </summary>
        /// <param name="albumId">The ID of the album to delete.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> DeleteAlbumAsync(int albumId, CancellationToken cancellationToken = default)
        {
            return await GetAsync<int>("deleteAlbum", new RequestParams().Add("album_id", albumId).ToDictionary(),
                cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Moves audio files to a different album.
        /// </summary>
        /// <param name="albumId">The destination album ID.</param>
        /// <param name="audioIds">A comma-separated list of audio IDs to move.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually <c>1</c> on success).</returns>
        public async Task<int> MoveToAlbumAsync(int albumId, string audioIds, CancellationToken cancellationToken = default)
        {
            var parameters = new RequestParams()
                .Add("album_id", albumId)
                .Add("audio_ids", audioIds)
                .ToDictionary();

            return await GetAsync<int>("moveToAlbum", parameters, cancellationToken: cancellationToken);
        }
    }
}
