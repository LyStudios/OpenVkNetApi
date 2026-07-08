using System;

namespace OpenVkNetApi.Events
{
    /// <summary>
    /// Contains information about a user typing event.
    /// Used in the <see cref="OpenVkNetApi.Services.LongPollService.OnUserTyping"/> event.
    /// </summary>
    public class UserTypingEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the ID of the user who is typing.
        /// </summary>
        public int UserId { get; }

        /// <summary>
        /// Gets the peer ID of the conversation where the user is typing.
        /// For private messages, this is the user's ID.
        /// For chat rooms, this is 2000000000 + chatId.
        /// </summary>
        public int PeerId { get; }

        /// <summary>
        /// Gets the raw chat ID if the user is typing in a group chat, otherwise <c>null</c>.
        /// </summary>
        public int? ChatId { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTypingEventArgs"/> class.
        /// </summary>
        /// <param name="userId">The ID of the user who is typing.</param>
        /// <param name="peerId">The peer ID of the conversation.</param>
        /// <param name="chatId">The optional chat ID.</param>
        public UserTypingEventArgs(int userId, int peerId, int? chatId = null)
        {
            UserId = userId;
            PeerId = peerId;
            ChatId = chatId;
        }
    }
}
