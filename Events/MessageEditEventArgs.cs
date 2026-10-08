using System;

namespace OpenVkNetApi.Events
{
    /// <summary>
    /// Contains information about a message edit event received via Long Poll.
    /// </summary>
    public class MessageEditEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the ID of the edited message.
        /// </summary>
        public long MessageId { get; }

        /// <summary>
        /// Gets the conversation peer ID.
        /// </summary>
        public long PeerId { get; }

        /// <summary>
        /// Gets the updated text of the message.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Gets the timestamp of the edit.
        /// </summary>
        public long Date { get; }

        /// <summary>
        /// Gets the message flags mask.
        /// </summary>
        public int Flags { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageEditEventArgs"/> class.
        /// </summary>
        public MessageEditEventArgs(long messageId, long peerId, string text, long date, int flags)
        {
            MessageId = messageId;
            PeerId = peerId;
            Text = text;
            Date = date;
            Flags = flags;
        }
    }
}
