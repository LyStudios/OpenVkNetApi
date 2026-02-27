using System;

namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// Specifies the name of the parameter when sent to the API.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ApiParameterAttribute : Attribute
    {
        public string Name { get; }
        public ApiParameterAttribute(string name) { Name = name; }
    }

    /// <summary>
    /// Ignores this property when converting an object to request parameters.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ApiIgnoreAttribute : Attribute { }

    /// <summary>
    /// Defines the format for converting a property's value to a string.
    /// </summary>
    public enum ParameterFormat
    {
        /// <summary>
        /// Default conversion (usually .ToString()).
        /// </summary>
        Default,
        /// <summary>
        /// Converts a boolean to "1" or "0".
        /// </summary>
        IntegerFromBool,
        // Add other formats as needed in the future
    }

    /// <summary>
    /// Specifies a custom format for converting a property's value to a string.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ApiParameterFormatAttribute : Attribute
    {
        public ParameterFormat Format { get; }
        public ApiParameterFormatAttribute(ParameterFormat format) { Format = format; }
    }
}
