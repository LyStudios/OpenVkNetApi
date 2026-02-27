using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// A convenient builder and converter for parameters of OpenVK API methods.
    /// </summary>
    public class RequestParams
    {
        private readonly Dictionary<string, string> _parameters = new Dictionary<string, string>();

        // Cache for reflection results to improve performance
        private static readonly ConcurrentDictionary<Type, List<PropertyInfo>> _propertyCache = new ConcurrentDictionary<Type, List<PropertyInfo>>();

        /// <summary>
        /// Adds a parameter to the request. This is for manual building.
        /// </summary>
        public RequestParams Add(string key, object? value)
        {
            if (value != null)
            {
                _parameters[key] = value.ToString();
            }
            return this;
        }

        /// <summary>
        /// Returns a copy of the parameter dictionary.
        /// </summary>
        public Dictionary<string, string> ToDictionary() => new Dictionary<string, string>(_parameters);

        /// <summary>
        /// Converts an object to a dictionary of parameters using reflection,
        /// honoring custom ApiParameter attributes.
        /// </summary>
        /// <param name="obj">The object to convert.</param>
        /// <returns>A dictionary of parameters.</returns>
        public static Dictionary<string, string> FromObject(object obj)
        {
            var dictionary = new Dictionary<string, string>();
            var type = obj.GetType();

            if (!_propertyCache.TryGetValue(type, out var properties))
            {
                properties = type.GetTypeInfo().DeclaredProperties
                                 .Where(p => p.GetCustomAttribute<ApiIgnoreAttribute>() == null)
                                 .ToList();
                _propertyCache[type] = properties;
            }

            foreach (var prop in properties)
            {
                var value = prop.GetValue(obj);
                if (value == null) continue;

                var paramNameAttr = prop.GetCustomAttribute<ApiParameterAttribute>();
                var key = paramNameAttr?.Name ?? prop.Name;

                var formatAttr = prop.GetCustomAttribute<ApiParameterFormatAttribute>();
                string stringValue;

                var propTypeInfo = prop.PropertyType.GetTypeInfo();
                if (propTypeInfo.IsEnum && propTypeInfo.IsDefined(typeof(FlagsAttribute), false))
                {
                    stringValue = EnumHelper.GetEnumFlagsDescription((Enum)value);
                }
                else
                {
                    switch (formatAttr?.Format)
                    {
                        case ParameterFormat.IntegerFromBool:
                            if (value is bool bInt)
                                stringValue = bInt ? "1" : "0";
                            else continue;
                            break;
                        
                        default: // Handles .ToString() for most types
                            stringValue = value.ToString();
                            break;
                    }
                }

                if (!string.IsNullOrEmpty(stringValue))
                {
                    dictionary[key] = stringValue;
                }
            }
            return dictionary;
        }
    }
}
