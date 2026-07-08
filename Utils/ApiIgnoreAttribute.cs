using System;

namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// Ignores this property when converting an object to request parameters.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ApiIgnoreAttribute : Attribute { }
}
