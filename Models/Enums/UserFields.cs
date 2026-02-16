using System;
using System.ComponentModel;

namespace OpenVkNetApi.Models.Enums
{
    /// <summary>
    /// Represents fields that can be requested for a user profile.
    /// </summary>
    [Flags]
    public enum UserFields : long
    {
        /// <summary>
        /// No fields.
        /// </summary>
        None = 0,
        /// <summary>
        /// Whether the user is verified.
        /// </summary>
        [Description("verified")]
        Verified = 1L << 0,
        /// <summary>
        /// The user's gender.
        /// </summary>
        [Description("sex")]
        Sex = 1L << 1,
        /// <summary>
        /// Whether the user has a profile photo.
        /// </summary>
        [Description("has_photo")]
        HasPhoto = 1L << 2,
        /// <summary>
        /// The URL of the maximum size original profile photo.
        /// </summary>
        [Description("photo_max_orig")]
        PhotoMaxOrig = 1L << 3,
        /// <summary>
        /// The URL of the maximum size profile photo.
        /// </summary>
        [Description("photo_max")]
        PhotoMax = 1L << 4,
        /// <summary>
        /// The URL of the 50px profile photo.
        /// </summary>
        [Description("photo_50")]
        Photo50 = 1L << 5,
        /// <summary>
        /// The URL of the 100px profile photo.
        /// </summary>
        [Description("photo_100")]
        Photo100 = 1L << 6,
        /// <summary>
        /// The URL of the 200px profile photo.
        /// </summary>
        [Description("photo_200")]
        Photo200 = 1L << 7,
        /// <summary>
        /// The URL of the 200px original profile photo.
        /// </summary>
        [Description("photo_200_orig")]
        Photo200Orig = 1L << 8,
        /// <summary>
        /// The URL of the 400px original profile photo.
        /// </summary>
        [Description("photo_400_orig")]
        Photo400Orig = 1L << 9,
        /// <summary>
        /// The user's status message.
        /// </summary>
        [Description("status")]
        Status = 1L << 10,
        /// <summary>
        /// The user's screen name.
        /// </summary>
        [Description("screen_name")]
        ScreenName = 1L << 11,
        /// <summary>
        /// The friendship status with the current user.
        /// </summary>
        [Description("friend_status")]
        FriendStatus = 1L << 12,
        /// <summary>
        /// The time the user was last seen online.
        /// </summary>
        [Description("last_seen")]
        LastSeen = 1L << 13,
        /// <summary>
        /// The user's favorite music.
        /// </summary>
        [Description("music")]
        Music = 1L << 14,
        /// <summary>
        /// The user's favorite movies.
        /// </summary>
        [Description("movies")]
        Movies = 1L << 15,
        /// <summary>
        /// The user's favorite TV shows.
        /// </summary>
        [Description("tv")]
        Tv = 1L << 16,
        /// <summary>
        /// The user's favorite books.
        /// </summary>
        [Description("books")]
        Books = 1L << 17,
        /// <summary>
        /// The user's city.
        /// </summary>
        [Description("city")]
        City = 1L << 18,
        /// <summary>
        /// The user's interests.
        /// </summary>
        [Description("interests")]
        Interests = 1L << 19,
        /// <summary>
        /// The user's favorite quotes.
        /// </summary>
        [Description("quotes")]
        Quotes = 1L << 20,
        /// <summary>
        /// The user's favorite games.
        /// </summary>
        [Description("games")]
        Games = 1L << 21,
        /// <summary>
        /// The user's email address.
        /// </summary>
        [Description("email")]
        Email = 1L << 22,
        /// <summary>
        /// The user's Telegram username.
        /// </summary>
        [Description("telegram")]
        Telegram = 1L << 23,
        /// <summary>
        /// The "About Me" section of the user's profile.
        /// </summary>
        [Description("about")]
        About = 1L << 24,
        /// <summary>
        /// The user's rating.
        /// </summary>
        [Description("rating")]
        Rating = 1L << 25,
        /// <summary>
        /// The user's counters (e.g., friends, followers).
        /// </summary>
        [Description("counters")]
        Counters = 1L << 26,
        /// <summary>
        /// Corrected counters.
        /// </summary>
        [Description("correct_counters")]
        CorrectCounters = 1L << 27,
        /// <summary>
        /// The user's GUID.
        /// </summary>
        [Description("guid")]
        Guid = 1L << 28,
        /// <summary>
        /// The user's profile background.
        /// </summary>
        [Description("background")]
        Background = 1L << 29,
        /// <summary>
        /// The user's registration date.
        /// </summary>
        [Description("reg_date")]
        RegDate = 1L << 30,
        /// <summary>
        /// Whether the user's account is deactivated.
        /// </summary>
        [Description("is_dead")]
        IsDead = 1L << 31,
        /// <summary>
        /// The user's nickname.
        /// </summary>
        [Description("nickname")]
        Nickname = 1L << 32,
        /// <summary>
        /// Whether the user is blacklisted by the current user.
        /// </summary>
        [Description("blacklisted_by_me")]
        BlacklistedByMe = 1L << 33,
        /// <summary>
        /// Whether the user is blacklisted.
        /// </summary>
        [Description("blacklisted")]
        Blacklisted = 1L << 34,
        /// <summary>
        /// The user's custom fields.
        /// </summary>
        [Description("custom_fields")]
        CustomFields = 1L << 35,
        /// <summary>
        /// The user's birth date.
        /// </summary>
        [Description("bdate")]
        Bdate = 1L << 36,
    }
}
