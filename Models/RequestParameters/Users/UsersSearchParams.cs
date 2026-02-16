using Newtonsoft.Json;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Models.RequestParameters.Users
{
    /// <summary>
    /// Parameters for the users.search method.
    /// </summary>
    public class UsersSearchParams
    {
        /// <summary>
        /// Search query.
        /// </summary>
        [JsonProperty("q")]
        public string Q { get; set; } = null!;

        /// <summary>
        /// A list of additional fields to return for each user.
        /// </summary>
        [JsonProperty("fields")]
        public UserFields Fields { get; set; } = UserFields.None;

        /// <summary>
        /// Offset for pagination.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// Number of users to return.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; } = 100;

        /// <summary>
        /// City to search by.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; } = "";

        /// <summary>
        /// Hometown to search by.
        /// </summary>
        [JsonProperty("hometown")]
        public string Hometown { get; set; } = "";

        /// <summary>
        /// Gender to search by (0 - any, 1 - female, 2 - male).
        /// </summary>
        [JsonProperty("sex")]
        public int Sex { get; set; } = 3; // 3 means any

        /// <summary>
        /// Relationship status to search by.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; } = 0;

        /// <summary>
        /// True to return only online users.
        /// </summary>
        [JsonProperty("online")]
        public bool Online { get; set; } = false;

        /// <summary>
        /// Sort order (0 - by popularity, 1 - by registration date).
        /// </summary>
        [JsonProperty("sort")]
        public int Sort { get; set; } = 0;

        /// <summary>
        /// Political views to search by.
        /// </summary>
        [JsonProperty("polit_views")]
        public int PolitViews { get; set; } = 0;

        /// <summary>
        /// Favorite music to search by.
        /// </summary>
        [JsonProperty("fav_music")]
        public string FavMusic { get; set; } = "";

        /// <summary>
        /// Favorite films to search by.
        /// </summary>
        [JsonProperty("fav_films")]
        public string FavFilms { get; set; } = "";

        /// <summary>
        /// Favorite TV shows to search by.
        /// </summary>
        [JsonProperty("fav_shows")]
        public string FavShows { get; set; } = "";

        /// <summary>
        /// Favorite books to search by.
        /// </summary>
        [JsonProperty("fav_books")]
        public string FavBooks { get; set; } = "";

        /// <summary>
        /// Interests to search by.
        /// </summary>
        [JsonProperty("interests")]
        public string Interests { get; set; } = "";
    }
}
