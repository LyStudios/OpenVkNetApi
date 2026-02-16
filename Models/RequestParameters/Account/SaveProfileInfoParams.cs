using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Account
{
    /// <summary>
    /// Parameters for the <c>account.saveProfileInfo</c> method.
    /// Used by <see cref="OpenVkNetApi.Methods.Account.SaveProfileInfoAsync"/>.
    /// </summary>
    public class SaveProfileInfoParams
    {
        /// <summary>
        /// The user's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string? FirstName { get; set; } = "";

        /// <summary>
        /// The user's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string? LastName { get; set; } = "";

        /// <summary>
        /// The user's screen name (e.g., "durov").
        /// </summary>
        [JsonProperty("screen_name")]
        public string? ScreenName { get; set; } = "";

        /// <summary>
        /// The user's gender.
        /// Possible values: <c>1</c> for female, <c>2</c> for male, <c>-1</c> for no change.
        /// </summary>
        [JsonProperty("sex")]
        public int Sex { get; set; } = -1;

        /// <summary>
        /// The user's relationship status.
        /// <c>-1</c> for no change.
        /// </summary>
        [JsonProperty("relation")]
        public int Relation { get; set; } = -1;

        /// <summary>
        /// The user's birth date in "DD.MM.YYYY" or "DD.MM" format.
        /// </summary>
        [JsonProperty("bdate")]
        public string? Bdate { get; set; } = "";

        /// <summary>
        /// The visibility of the birth date.
        /// Possible values: <c>0</c> for hidden, <c>1</c> for day and month, <c>2</c> for full date, <c>-1</c> for no change.
        /// </summary>
        [JsonProperty("bdate_visibility")]
        public int BdateVisibility { get; set; } = -1;

        /// <summary>
        /// The user's home town.
        /// </summary>
        [JsonProperty("home_town")]
        public string? HomeTown { get; set; } = "";

        /// <summary>
        /// The user's text status.
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; } = "";

        /// <summary>
        /// The user's Telegram username (without the '@' symbol).
        /// </summary>
        [JsonProperty("telegram")]
        public string? Telegram { get; set; } = "";
    }
}
