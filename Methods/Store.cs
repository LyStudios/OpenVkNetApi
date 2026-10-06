using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Stickers;
using OpenVkNetApi.Models.Store;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with the store catalog, products, and stickers keywords.
    /// Encapsulates the <c>store.*</c> methods of the OpenVK API.
    /// </summary>
    public class Store : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Store"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Store(OpenVkApi api) : base(api, "store") { }

        /// <summary>
        /// Returns store products (such as sticker packs).
        /// </summary>
        public async Task<Collection<StoreProduct>> GetProductsAsync(
            string type = "stickers",
            string filters = "",
            bool extended = true,
            int count = 50,
            int offset = 0,
            IEnumerable<int> productIds = null,
            int userId = 0,
            CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("type", type)
                .Add("filters", filters)
                .Add("extended", extended ? 1 : 0)
                .Add("count", count)
                .Add("offset", offset)
                .Add("product_ids", productIds)
                .Add("user_id", userId > 0 ? userId : (int?)null)
                .ToDictionary();

            return await GetAsync<Collection<StoreProduct>>("getProducts", parameters, ct);
        }

        /// <summary>
        /// Returns available stock items from the store catalog.
        /// </summary>
        public async Task<Collection<StoreProduct>> GetStockItemsAsync(
            string type = "stickers",
            string section = "",
            bool extended = true,
            int count = 50,
            int offset = 0,
            string merchant = "",
            CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("type", type)
                .Add("section", section)
                .Add("extended", extended ? 1 : 0)
                .Add("count", count)
                .Add("offset", offset)
                .Add("merchant", merchant)
                .ToDictionary();

            return await GetAsync<Collection<StoreProduct>>("getStockItems", parameters, ct);
        }

        /// <summary>
        /// Returns keywords mapping for instant sticker suggestions.
        /// </summary>
        public async Task<StickersKeywords> GetStickersKeywordsAsync(
            bool aliases = true,
            bool allProducts = false,
            bool needStickers = true,
            int count = 0,
            int userId = 0,
            CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("aliases", aliases ? 1 : 0)
                .Add("all_products", allProducts ? 1 : 0)
                .Add("need_stickers", needStickers ? 1 : 0)
                .Add("count", count > 0 ? count : (int?)null)
                .Add("user_id", userId > 0 ? userId : (int?)null)
                .ToDictionary();

            return await GetAsync<StickersKeywords>("getStickersKeywords", parameters, ct);
        }

        /// <summary>
        /// Activates a purchased store product.
        /// </summary>
        public async Task<bool> ActivateProductAsync(int productId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("product_id", productId)
                .ToDictionary();

            var res = await PostAsync<int>("activateProduct", parameters, ct);
            return res == 1;
        }

        /// <summary>
        /// Deactivates a purchased store product.
        /// </summary>
        public async Task<bool> DeactivateProductAsync(int productId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("product_id", productId)
                .ToDictionary();

            var res = await PostAsync<int>("deactivateProduct", parameters, ct);
            return res == 1;
        }

        /// <summary>
        /// Purchases a store product.
        /// </summary>
        public async Task<StickerBuyResult> BuyAsync(int productId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("product_id", productId)
                .ToDictionary();

            return await PostAsync<StickerBuyResult>("buy", parameters, ct);
        }

        /// <summary>
        /// Returns the user's favorite sticker IDs.
        /// </summary>
        public async Task<List<int>> GetFavoriteStickersAsync(CancellationToken ct = default)
        {
            var res = await GetAsync<Collection<int>>("getFavoriteStickers", null, ct);
            return res?.Items ?? new List<int>();
        }

        /// <summary>
        /// Adds a sticker to favorites.
        /// </summary>
        public async Task<bool> AddFavoriteStickerAsync(int stickerId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("sticker_id", stickerId)
                .ToDictionary();

            var res = await PostAsync<int>("addFavoriteSticker", parameters, ct);
            return res == 1;
        }

        /// <summary>
        /// Removes a sticker from favorites.
        /// </summary>
        public async Task<bool> RemoveFavoriteStickerAsync(int stickerId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("sticker_id", stickerId)
                .ToDictionary();

            var res = await PostAsync<int>("removeFavoriteSticker", parameters, ct);
            return res == 1;
        }

        /// <summary>
        /// Returns recent sticker IDs used by the user.
        /// </summary>
        public async Task<List<int>> GetRecentStickersAsync(CancellationToken ct = default)
        {
            var res = await GetAsync<Collection<int>>("getRecentStickers", null, ct);
            return res?.Items ?? new List<int>();
        }

        /// <summary>
        /// Records a sticker as recently used.
        /// </summary>
        public async Task<bool> AddRecentStickerAsync(int stickerId, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("sticker_id", stickerId)
                .ToDictionary();

            var res = await PostAsync<int>("addRecentSticker", parameters, ct);
            return res == 1;
        }

        /// <summary>
        /// Clears the user's recent stickers list.
        /// </summary>
        public async Task<bool> ClearRecentStickersAsync(CancellationToken ct = default)
        {
            var res = await PostAsync<int>("clearRecentStickers", null, ct);
            return res == 1;
        }
    }
}
