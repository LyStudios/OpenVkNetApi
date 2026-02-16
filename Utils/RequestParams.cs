using System.Collections.Generic;

namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// A convenient builder for parameters of OpenVK API methods.
    /// Supports chained calls and automatic type conversion.
    /// </summary>
    public class RequestParams
    {
        private readonly Dictionary<string, string> _parameters = new Dictionary<string, string>();

        /// <summary>
        /// Adds a parameter to the request, skipping null and empty string values.
        /// </summary>
        /// <param name="key">The name of the parameter for the API.</param>
        /// <param name="value">The value of the parameter (automatically converted to string).</param>
        /// <returns>The current instance for chained calls.</returns>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item><description><c>string</c> — as is (skips empty strings)</description></item>
        /// <item><description><c>bool</c> — <c>1</c>/<c>0</c></description></item>
        /// <item><description>Others — <see cref="object.ToString()"/></description></item>
        /// </list>
        /// </remarks>
        public RequestParams Add(string key, object? value)
        {
            if (value == null) return this;

            string strValue;
            switch (value)
            {
                case string s:
                    if (string.IsNullOrEmpty(s)) return this;
                    strValue = s;
                    break;
                case bool b:
                    strValue = b ? "1" : "0";
                    break;
                default:
                    strValue = value.ToString();
                    break;
            }

            _parameters[key] = strValue;
            return this;
        }

        /// <summary>
        /// Returns a copy of the parameter dictionary for use in an HTTP request.
        /// </summary>
        /// <returns>A new dictionary of parameters of type <c>Dictionary&lt;string, string&gt;</c>.</returns>
        public Dictionary<string, string> ToDictionary() => new Dictionary<string, string>(_parameters);
    }
}
