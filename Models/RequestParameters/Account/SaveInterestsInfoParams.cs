using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Account
{
    /// <summary>
    /// Parameters for the <c>account.saveInterestsInfo</c> method.
    /// Used by <see cref="OpenVkNetApi.Methods.Account.SaveInterestsInfoAsync"/>.
    /// </summary>
    public class SaveInterestsInfoParams
    {
        /// <summary>
        /// User's general interests.
        /// </summary>
        [JsonProperty("interests")]
        public string? Interests { get; set; } = "";

        /// <summary>
        /// User's favorite music.
        /// </summary>
        [JsonProperty("fav_music")]
        public string? FavMusic { get; set; } = "";

        /// <summary>
        /// User's favorite films.
        /// </summary>
        [JsonProperty("fav_films")]
        public string? FavFilms { get; set; } = "";

        /// <summary>
        /// User's favorite TV shows.
        /// </summary>
        [JsonProperty("fav_shows")]
        public string? FavShows { get; set; } = "";

        /// <summary>
        /// User's favorite books.
        /// </summary>
        [JsonProperty("fav_books")]
        public string? FavBooks { get; set; } = "";

        /// <summary>
        /// User's favorite quote.
        /// </summary>
        [JsonProperty("fav_quote")]
        public string? FavQuote { get; set; } = "";

        /// <summary>
        /// User's favorite games.
        /// </summary>
        [JsonProperty("fav_games")]
        public string? FavGames { get; set; } = "";

        /// <summary>
        /// Additional information about the user ("About Me").
        /// </summary>
        [JsonProperty("about")]
        public string? About { get; set; } = "";
    }
}
