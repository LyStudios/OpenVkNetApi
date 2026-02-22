using OpenVkNetApi.Models.Messages;
using System;

namespace OpenVkNetApi.Events
{
    /// <summary>
    /// Event arguments for a new message received via Long Poll.
    /// </summary>
    public class NewMessageEventArgs : EventArgs
    {
        /// <summary>
        /// The new message object.
        /// </summary>
        public Message Message { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewMessageEventArgs"/> class.
        /// </summary>
        /// <param name="message">The new message.</param>
        public NewMessageEventArgs(Message message)
        {
            Message = message;
        }
    }
}
