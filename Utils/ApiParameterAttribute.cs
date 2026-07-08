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
}
