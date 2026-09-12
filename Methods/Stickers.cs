using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Stickers;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with stickers and sticker packs.
    /// Encapsulates the <c>stickers.*</c> methods of the OpenVK API.
    /// </summary>
    public class Stickers : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stickers"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Stickers(OpenVkApi api) : base(api, "stickers") { }

        /// <summary>
        /// Returns a list of sticker packs available to the user.
        /// </summary>
        /// <param name="userId">The user ID (defaults to current user if 0).</param>
        /// <param name="count">The number of packs to return.</param>
        /// <param name="offset">The offset for pagination.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{StickerPack}"/> containing sticker packs.</returns>
        public async Task<Collection<StickerPack>> GetAsync(int userId = 0, int count = 50, int offset = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("user_id", userId > 0 ? userId : (int?)null)
                .Add("count", count)
                .Add("offset", offset)
                .ToDictionary();

            return await GetAsync<Collection<StickerPack>>("get", parameters, ct);
        }

        /// <summary>
        /// Returns all available sticker packs from the catalog.
        /// </summary>
        /// <param name="count">The number of packs to return.</param>
        /// <param name="offset">The offset for pagination.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{StickerPack}"/> containing all sticker packs.</returns>
        [AllowAnonymous]
        public async Task<Collection<StickerPack>> GetAllAsync(int count = 50, int offset = 0, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("count", count)
                .Add("offset", offset)
                .ToDictionary();

            return await GetAsync<Collection<StickerPack>>("getAll", parameters, ct);
        }

        /// <summary>
        /// Returns information about a specific sticker pack and its stickers.
        /// </summary>
        /// <param name="stickerpackId">The sticker pack ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="StickerPack"/> object with stickers.</returns>
        [AllowAnonymous]
        public async Task<StickerPack> GetFromAsync(int stickerpackId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("stickerpack_id", stickerpackId)
                .ToDictionary();

            return await GetAsync<StickerPack>("getFrom", parameters, ct);
        }

        /// <summary>
        /// Purchases or adds a sticker pack to the current user's collection.
        /// </summary>
        /// <param name="stickerpackId">The sticker pack ID to buy.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="StickerBuyResult"/> with purchase status.</returns>
        public async Task<StickerBuyResult> BuyAsync(int stickerpackId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("stickerpack_id", stickerpackId)
                .ToDictionary();

            return await PostAsync<StickerBuyResult>("buy", parameters, ct);
        }
    }
}
