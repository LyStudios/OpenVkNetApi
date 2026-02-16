using System;

namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// An exception specific to OpenVK API errors.
    /// Used when processing error responses from the server.
    /// </summary>
    public class OvkApiException : Exception
    {
        /// <summary>
        /// The API error code.
        /// </summary>
        public int ErrorCode { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OvkApiException"/> class with an error code and message.
        /// </summary>
        /// <param name="code">The error code from the API response.</param>
        /// <param name="message">The text description of the error.</param>
        public OvkApiException(int code, string? message) : base(message)
        {
            ErrorCode = code;
        }
    }
}
