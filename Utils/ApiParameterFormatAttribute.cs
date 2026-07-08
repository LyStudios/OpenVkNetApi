using System;

namespace OpenVkNetApi.Utils
{
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
