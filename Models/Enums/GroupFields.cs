using System;
using System.ComponentModel;

namespace OpenVkNetApi.Models.Enums
{
    /// <summary>
    /// Represents fields that can be requested for a group.
    /// </summary>
    [Flags]
    public enum GroupFields
    {
        /// <summary>
        /// No fields.
        /// </summary>
        None = 0,
        /// <summary>
        /// Whether the group is verified.
        /// </summary>
        [Description("verified")]
        Verified = 1 << 0,
        /// <summary>
        /// Whether the group has a profile photo.
        /// </summary>
        [Description("has_photo")]
        HasPhoto = 1 << 1,
        /// <summary>
        /// The URL of the maximum size original profile photo.
        /// </summary>
        [Description("photo_max_orig")]
        PhotoMaxOrig = 1 << 2,
        /// <summary>
        /// The URL of the maximum size profile photo.
        /// </summary>
        [Description("photo_max")]
        PhotoMax = 1 << 3,
        /// <summary>
        /// The URL of the 50px profile photo.
        /// </summary>
        [Description("photo_50")]
        Photo50 = 1 << 4,
        /// <summary>
        /// The URL of the 100px profile photo.
        /// </summary>
        [Description("photo_100")]
        Photo100 = 1 << 5,
        /// <summary>
        /// The URL of the 200px profile photo.
        /// </summary>
        [Description("photo_200")]
        Photo200 = 1 << 6,
        /// <summary>
        /// The URL of the 200px original profile photo.
        /// </summary>
        [Description("photo_200_orig")]
        Photo200Orig = 1 << 7,
        /// <summary>
        /// The URL of the 400px original profile photo.
        /// </summary>
        [Description("photo_400_orig")]
        Photo400Orig = 1 << 8,
        /// <summary>
        /// The number of members in the group.
        /// </summary>
        [Description("members_count")]
        MembersCount = 1 << 9,
        /// <summary>
        /// Whether the current user can suggest posts.
        /// </summary>
        [Description("can_suggest")]
        CanSuggest = 1 << 10,
        /// <summary>
        /// The group's profile background.
        /// </summary>
        [Description("background")]
        Background = 1 << 11,
        /// <summary>
        /// The number of suggested posts.
        /// </summary>
        [Description("suggested_count")]
        SuggestedCount = 1 << 12,
        /// <summary>
        /// The group's website.
        /// </summary>
        [Description("site")]
        Site = 1 << 13,
        /// <summary>
        /// The group's description.
        /// </summary>
        [Description("description")]
        Description = 1 << 14,
        /// <summary>
        /// The group's contact information.
        /// </summary>
        [Description("contacts")]
        Contacts = 1 << 15,
        /// <summary>
        /// Whether the current user can post on the group's wall.
        /// </summary>
        [Description("can_post")]
        CanPost = 1 << 16,
        /// <summary>
        /// The group's screen name.
        /// </summary>
        [Description("screen_name")]
        ScreenName = 1 << 17,
        /// <summary>
        /// Whether the current user is an administrator of the group.
        /// </summary>
        [Description("is_admin")]
        IsAdmin = 1 << 18,
        /// <summary>
        /// Whether the current user is a member of the group.
        /// </summary>
        [Description("is_member")]
        IsMember = 1 << 19,
        /// <summary>
        /// Whether the current user is an advertiser in the group.
        /// </summary>
        [Description("is_advertiser")]
        IsAdvertiser = 1 << 20,
    }
}
