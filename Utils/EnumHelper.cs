using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// Provides utility methods for working with enums, especially those marked with <see cref="FlagsAttribute"/> and <see cref="DescriptionAttribute"/>.
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Converts an enum flags value into a comma-separated string of its Description attributes.
        /// If a DescriptionAttribute is not found, the enum member's name (lowercase) is used.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumValue">The enum flags value.</param>
        /// <returns>A comma-separated string of descriptions or enum member names.</returns>
        public static string GetEnumFlagsDescription<T>(T enumValue) where T : Enum
        {
            if (enumValue.Equals(default(T))) // Handle None or default value
            {
                return "";
            }

            var type = enumValue.GetType();
            var result = new StringBuilder();
            var enumValues = Enum.GetValues(type).Cast<T>().ToList();

            foreach (var value in enumValues)
            {
                if (value.Equals(default(T))) continue; // Skip None or default value itself

                if (enumValue.HasFlag(value))
                {
                    if (result.Length > 0)
                    {
                        result.Append(",");
                    }
                    var field = type.GetTypeInfo().GetDeclaredField(value.ToString());
                    var attributes = field?.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    var description = attributes != null && attributes.Any() ? ((DescriptionAttribute)attributes.First()).Description : value.ToString().ToLower();
                    result.Append(description);
                }
            }

            return result.ToString();
        }
    }
}
