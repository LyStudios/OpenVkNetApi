using System;

namespace OpenVkNetApi.Events
{
    /// <summary>
    /// Contains information about a user going offline.
    /// </summary>
    public class UserOfflineEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the ID of the user who went offline.
        /// </summary>
        public long UserId { get; }

        /// <summary>
        /// Gets the offline flag (0: manual logout / left site, 1: inactivity timeout).
        /// </summary>
        public int Flags { get; }

        /// <summary>
        /// Gets the timestamp when the user went offline.
        /// </summary>
        public long Timestamp { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserOfflineEventArgs"/> class.
        /// </summary>
        public UserOfflineEventArgs(long userId, int flags, long timestamp)
        {
            UserId = userId;
            Flags = flags;
            Timestamp = timestamp;
        }
    }
}
