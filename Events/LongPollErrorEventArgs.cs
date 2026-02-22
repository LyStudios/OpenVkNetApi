using System;

namespace OpenVkNetApi.Events
{
    /// <summary>
    /// Contains information about a LongPoll error.
    /// Used in the <see cref="LongPollService.OnError"/> event.
    /// </summary>
    public class LongPollErrorEventArgs : EventArgs
    {
        /// <summary>
        /// The error message describing what went wrong.
        /// </summary>
        public string ErrorMessage { get; }

        /// <summary>
        /// The exception that caused the error, if any.
        /// Can be <c>null</c> if there was no exception.
        /// </summary>
        public Exception? Exception { get; }

        /// <summary>
        /// The error code, if available.
        /// Can be <c>null</c> if no code is provided.
        /// </summary>
        public int? ErrorCode { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LongPollErrorEventArgs"/> class.
        /// </summary>
        /// <param name="msg">The error message.</param>
        /// <param name="ex">The exception that caused the error (optional).</param>
        /// <param name="code">The error code (optional).</param>
        public LongPollErrorEventArgs(string msg, Exception? ex = null, int? code = null)
        {
            ErrorMessage = msg;
            Exception = ex;
            ErrorCode = code;
        }
    }
}
