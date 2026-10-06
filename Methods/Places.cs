using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Places;
using OpenVkNetApi.Utils;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides methods for working with places and geographic data.
    /// Encapsulates the <c>places.*</c> methods of the OpenVK API.
    /// </summary>
    public class Places : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Places"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Places(OpenVkApi api) : base(api, "places") { }

        /// <summary>
        /// Returns information about cities by their IDs.
        /// </summary>
        /// <param name="cids">A collection of city IDs.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="City"/> objects.</returns>
        [AllowAnonymous]
        public async Task<List<City>> GetCityByIdAsync(IEnumerable<int> cids, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("cids", cids != null ? string.Join(",", cids) : "")
                .ToDictionary();

            return await GetAsync<List<City>>("getCityById", parameters, ct);
        }

        /// <summary>
        /// Returns information about a city by its ID.
        /// </summary>
        /// <param name="cid">The city ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="City"/> object, or null if not found.</returns>
        [AllowAnonymous]
        public async Task<City> GetCityByIdAsync(int cid, CancellationToken ct = default)
        {
            var list = await GetCityByIdAsync(new[] { cid }, ct);
            return list != null && list.Count > 0 ? list[0] : null;
        }

        /// <summary>
        /// Returns information about countries by their IDs.
        /// </summary>
        /// <param name="cids">A collection of country IDs.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A list of <see cref="Country"/> objects.</returns>
        [AllowAnonymous]
        public async Task<List<Country>> GetCountryByIdAsync(IEnumerable<int> cids, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("cids", cids != null ? string.Join(",", cids) : "")
                .ToDictionary();

            return await GetAsync<List<Country>>("getCountryById", parameters, ct);
        }

        /// <summary>
        /// Returns information about a country by its ID.
        /// </summary>
        /// <param name="cid">The country ID.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Country"/> object, or null if not found.</returns>
        [AllowAnonymous]
        public async Task<Country> GetCountryByIdAsync(int cid, CancellationToken ct = default)
        {
            var list = await GetCountryByIdAsync(new[] { cid }, ct);
            return list != null && list.Count > 0 ? list[0] : null;
        }

        /// <summary>
        /// Returns information about cities by their IDs (alias for getCitiesById).
        /// </summary>
        [AllowAnonymous]
        public async Task<List<City>> GetCitiesByIdAsync(IEnumerable<int> cityIds, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("city_ids", cityIds != null ? string.Join(",", cityIds) : "")
                .ToDictionary();

            return await GetAsync<List<City>>("getCitiesById", parameters, ct);
        }

        /// <summary>
        /// Returns information about countries by their IDs (alias for getCountriesById).
        /// </summary>
        [AllowAnonymous]
        public async Task<List<Country>> GetCountriesByIdAsync(IEnumerable<int> countryIds, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("country_ids", countryIds != null ? string.Join(",", countryIds) : "")
                .ToDictionary();

            return await GetAsync<List<Country>>("getCountriesById", parameters, ct);
        }

        /// <summary>
        /// Checks in a location.
        /// </summary>
        /// <param name="placeId">The place ID.</param>
        /// <param name="text">The check-in comment text.</param>
        /// <param name="latitude">Geographic latitude.</param>
        /// <param name="longitude">Geographic longitude.</param>
        /// <param name="friendsOnly">True to allow only friends to view the check-in.</param>
        /// <param name="services">List of services to export the check-in to.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An integer representing the API's success code (usually 1 on success).</returns>
        public async Task<int> CheckinAsync(int placeId = 0, string text = "", double latitude = 0.0, double longitude = 0.0, bool friendsOnly = false, string services = "", CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("place_id", placeId)
                .Add("text", text)
                .Add("lat", latitude)
                .Add("long", longitude)
                .Add("friends_only", friendsOnly ? 1 : 0)
                .Add("services", services)
                .ToDictionary();

            return await PostAsync<int>("checkin", parameters, ct);
        }

        /// <summary>
        /// Returns a list of check-ins.
        /// </summary>
        /// <param name="latitude">Geographic latitude.</param>
        /// <param name="longitude">Geographic longitude.</param>
        /// <param name="offset">Offset needed to return a specific subset of check-ins.</param>
        /// <param name="count">Number of check-ins to return.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A <see cref="Collection{Checkin}"/> containing check-ins.</returns>
        [AllowAnonymous]
        public async Task<Collection<Checkin>> GetCheckinsAsync(double latitude = 0.0, double longitude = 0.0, int offset = 0, int count = 20, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("latitude", latitude)
                .Add("longitude", longitude)
                .Add("offset", offset)
                .Add("count", count)
                .ToDictionary();

            return await GetAsync<Collection<Checkin>>("getCheckins", parameters, ct);
        }
    }
}
