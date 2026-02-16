using System;
using System.ComponentModel;

namespace OpenVkNetApi.Models.Enums
{
    /// <summary>
    /// Represents fields that can be requested about the OpenVK instance.
    /// </summary>
    [Flags]
    public enum OvkInstanceFields
    {
        /// <summary>
        /// No fields.
        /// </summary>
        None = 0,
        /// <summary>
        /// Instance statistics.
        /// </summary>
        [Description("statistics")]
        Statistics = 1 << 0,
        /// <summary>
        /// List of instance administrators.
        /// </summary>
        [Description("administrators")]
        Administrators = 1 << 1,
        /// <summary>
        /// List of popular groups on the instance.
        /// </summary>
        [Description("popular_groups")]
        PopularGroups = 1 << 2,
        /// <summary>
        /// Associated instance links.
        /// </summary>
        [Description("links")]
        Links = 1 << 3,
    }
}
