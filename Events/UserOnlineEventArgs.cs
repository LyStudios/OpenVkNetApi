using System;

namespace OpenVkNetApi.Events
{
    /// <summary>
    /// Contains information about a user coming online.
    /// </summary>
    public class UserOnlineEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the ID of the user who came online.
        /// </summary>
        public int UserId { get; }

        /// <summary>
        /// Gets the platform ID (1: mobile/web, 2: iPhone, 3: iPad, 4: Android, 5: Windows Phone, 6: Windows, 7: Web).
        /// </summary>
        public int PlatformId { get; }

        /// <summary>
        /// Gets the timestamp when the user was last active.
        /// </summary>
        public long Timestamp { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserOnlineEventArgs"/> class.
        /// </summary>
        public UserOnlineEventArgs(int userId, int platformId, long timestamp)
        {
            UserId = userId;
            PlatformId = platformId;
            Timestamp = timestamp;
        }
    }
}
