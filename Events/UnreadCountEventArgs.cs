using System;

namespace OpenVkNetApi.Events
{
    /// <summary>
    /// Contains information about an unread count badge update.
    /// </summary>
    public class UnreadCountEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the new unread messages count.
        /// </summary>
        public int UnreadCount { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnreadCountEventArgs"/> class.
        /// </summary>
        public UnreadCountEventArgs(int unreadCount)
        {
            UnreadCount = unreadCount;
        }
    }
}
