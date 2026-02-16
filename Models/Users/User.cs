using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Users
{
    /// <summary>
    /// Represents a full user profile.
    /// </summary>
    public class User : UserBase
    {
        /// <summary>
        /// Indicates if the user's profile is closed.
        /// </summary>
        [JsonProperty("is_closed")]
        public bool? IsClosed { get; set; }

        /// <summary>
        /// Indicates if the current user can access the closed profile.
        /// </summary>
        [JsonProperty("can_access_closed")]
        public bool? CanAccessClosed { get; set; }

        /// <summary>
        /// A string indicating if the account is deactivated (e.g., "deleted", "banned").
        /// </summary>
        [JsonProperty("deactivated")]
        public string? Deactivated { get; set; }

        /// <summary>
        /// Indicates if the user is currently online.
        /// </summary>
        [JsonProperty("online")]
        public int? Online { get; set; }

        /// <summary>
        /// The user's screen name (short address).
        /// </summary>
        [JsonProperty("screen_name")]
        public string? ScreenName { get; set; }

        /// <summary>
        /// The user's gender (1 for female, 2 for male, 0 for unspecified).
        /// </summary>
        [JsonProperty("sex")]
        public int? Sex { get; set; }

        /// <summary>
        /// Indicates if the user's profile is verified.
        /// </summary>
        [JsonProperty("verified")]
        public int? Verified { get; set; }

        /// <summary>
        /// Indicates if the user has a profile photo.
        /// </summary>
        [JsonProperty("has_photo")]
        public int? HasPhoto { get; set; }

        /// <summary>
        /// The user's birth date.
        /// </summary>
        [JsonProperty("bdate")]
        public string? Bdate { get; set; }

        /// <summary>
        /// The visibility of the user's birth date.
        /// </summary>
        [JsonProperty("bdate_visibility")]
        public int? BdateVisibility { get; set; }

        /// <summary>
        /// The user's status message.
        /// </summary>
        [JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The user's nickname.
        /// </summary>
        [JsonProperty("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// The user's city.
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// The "About Me" section of the user's profile.
        /// </summary>
        [JsonProperty("about")]
        public string? About { get; set; }

        /// <summary>
        /// The user's interests.
        /// </summary>
        [JsonProperty("interests")]
        public string? Interests { get; set; }

        /// <summary>
        /// The user's favorite music.
        /// </summary>
        [JsonProperty("music")]
        public string? Music { get; set; }

        /// <summary>
        /// The user's favorite movies.
        /// </summary>
        [JsonProperty("movies")]
        public string? Movies { get; set; }

        /// <summary>
        /// The user's favorite TV shows.
        /// </summary>
        [JsonProperty("tv")]
        public string? Tv { get; set; }

        /// <summary>
        /// The user's favorite books.
        /// </summary>
        [JsonProperty("books")]
        public string? Books { get; set; }

        /// <summary>
        /// The user's favorite quotes.
        /// </summary>
        [JsonProperty("quotes")]
        public string? Quotes { get; set; }

        /// <summary>
        /// The user's favorite games.
        /// </summary>
        [JsonProperty("games")]
        public string? Games { get; set; }

        /// <summary>
        /// The user's Telegram username.
        /// </summary>
        [JsonProperty("telegram")]
        public string? Telegram { get; set; }

        /// <summary>
        /// The user's email address.
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The user's rating.
        /// </summary>
        [JsonProperty("rating")]
        public int? Rating { get; set; }

        /// <summary>
        /// The friendship status with the current user.
        /// </summary>
        [JsonProperty("friend_status")]
        public int? FriendStatus { get; set; }

        /// <summary>
        /// Information about when the user was last seen online.
        /// </summary>
        [JsonProperty("last_seen")]
        public LastSeen? LastSeen { get; set; }

        /// <summary>
        /// Various counters for the user (e.g., friends, followers).
        /// </summary>
        [JsonProperty("counters")]
        public Counters? Counters { get; set; }

        /// <summary>
        /// URL of the 50x50px profile photo.
        /// </summary>
        [JsonProperty("photo_50")]
        public string? Photo50 { get; set; }

        /// <summary>
        /// URL of the 100x100px profile photo.
        /// </summary>
        [JsonProperty("photo_100")]
        public string? Photo100 { get; set; }

        /// <summary>
        /// URL of the 200x200px profile photo.
        /// </summary>
        [JsonProperty("photo_200")]
        public string? Photo200 { get; set; }

        /// <summary>
        /// URL of the original 200px profile photo.
        /// </summary>
        [JsonProperty("photo_200_orig")]
        public string? Photo200Orig { get; set; }

        /// <summary>
        /// URL of the original 400px profile photo.
        /// </summary>
        [JsonProperty("photo_400_orig")]
        public string? Photo400Orig { get; set; }

        /// <summary>
        /// URL of the maximum size profile photo.
        /// </summary>
        [JsonProperty("photo_max")]
        public string? PhotoMax { get; set; }

        /// <summary>
        /// URL of the maximum size original profile photo.
        /// </summary>
        [JsonProperty("photo_max_orig")]
        public string? PhotoMaxOrig { get; set; }

        /// <summary>
        /// The user's profile background.
        /// </summary>
        [JsonProperty("background")]
        public List<string>? Background { get; set; }

        /// <summary>
        /// A list of custom fields in the user's profile.
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<CustomField>? CustomFields { get; set; }

        /// <summary>
        /// The user's GUID.
        /// </summary>
        [JsonProperty("guid")]
        public string? Guid { get; set; }

        /// <summary>
        /// The user's registration date in Unix time.
        /// </summary>
        [JsonProperty("reg_date")]
        public long? RegDate { get; set; }

        /// <summary>
        /// Indicates if the user's account is deactivated.
        /// </summary>
        [JsonProperty("is_dead")]
        public bool? IsDead { get; set; }

        /// <summary>
        /// Indicates if the user is blacklisted.
        /// </summary>
        [JsonProperty("blacklisted")]
        public int? Blacklisted { get; set; }

        /// <summary>
        /// Indicates if the user is blacklisted by the current user.
        /// </summary>
        [JsonProperty("blacklisted_by_me")]
        public int? BlacklistedByMe { get; set; }       
    }
}
