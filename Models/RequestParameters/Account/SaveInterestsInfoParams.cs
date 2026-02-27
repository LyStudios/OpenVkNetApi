using OpenVkNetApi.Utils;

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
        [ApiParameter("interests")]
        public string? Interests { get; set; } = null;

        /// <summary>
        /// User's favorite music.
        /// </summary>
        [ApiParameter("fav_music")]
        public string? FavMusic { get; set; } = null;

        /// <summary>
        /// User's favorite films.
        /// </summary>
        [ApiParameter("fav_films")]
        public string? FavFilms { get; set; } = null;

        /// <summary>
        /// User's favorite TV shows.
        /// </summary>
        [ApiParameter("fav_shows")]
        public string? FavShows { get; set; } = null;

        /// <summary>
        /// User's favorite books.
        /// </summary>
        [ApiParameter("fav_books")]
        public string? FavBooks { get; set; } = null;

        /// <summary>
        /// User's favorite quote.
        /// </summary>
        [ApiParameter("fav_quote")]
        public string? FavQuote { get; set; } = null;

        /// <summary>
        /// User's favorite games.
        /// </summary>
        [ApiParameter("fav_games")]
        public string? FavGames { get; set; } = null;

        /// <summary>
        /// Additional information about the user ("About Me").
        /// </summary>
        [ApiParameter("about")]
        public string? About { get; set; } = null;
    }
}
