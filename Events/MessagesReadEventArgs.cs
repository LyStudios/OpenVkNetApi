using System;

namespace OpenVkNetApi.Events
{
    /// <summary>
    /// Contains information about messages being read in a conversation.
    /// </summary>
    public class MessagesReadEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the peer ID of the conversation.
        /// </summary>
        public long PeerId { get; }

        /// <summary>
        /// Gets the local message ID up to which messages were read.
        /// </summary>
        public long LocalId { get; }

        /// <summary>
        /// Gets a value indicating whether outgoing messages were read (true), or incoming (false).
        /// </summary>
        public bool IsOutgoing { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesReadEventArgs"/> class.
        /// </summary>
        public MessagesReadEventArgs(long peerId, long localId, bool isOutgoing)
        {
            PeerId = peerId;
            LocalId = localId;
            IsOutgoing = isOutgoing;
        }
    }
}
