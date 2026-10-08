using System;

namespace OpenVkNetApi.Events
{
    /// <summary>
    /// Contains information about a conversation change event.
    /// </summary>
    public class ChatChangeEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the local chat ID.
        /// </summary>
        public long ChatId { get; }

        /// <summary>
        /// Gets the peer ID of the conversation.
        /// </summary>
        public long PeerId { get; }

        /// <summary>
        /// Gets the change type ID (1: title, 2: photo, 3: admin, 5: pin, 6: join, 7: leave, 8: kick).
        /// </summary>
        public int TypeId { get; }

        /// <summary>
        /// Gets a value indicating whether the change was triggered by the current user.
        /// </summary>
        public bool Self { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatChangeEventArgs"/> class.
        /// </summary>
        public ChatChangeEventArgs(long chatId, long peerId, int typeId, bool self)
        {
            ChatId = chatId;
            PeerId = peerId;
            TypeId = typeId;
            Self = self;
        }
    }
}
