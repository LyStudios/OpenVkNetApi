using System;

namespace OpenVkNetApi.Events
{
    /// <summary>
    /// Contains information about a user typing or voice message recording event.
    /// Used in the <see cref="OpenVkNetApi.Services.LongPollService.OnUserTyping"/> event.
    /// </summary>
    public class UserTypingEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the ID of the user who is typing.
        /// </summary>
        public long UserId { get; }

        /// <summary>
        /// Gets the peer ID of the conversation where the user is typing.
        /// For private messages, this is the user's ID.
        /// For chat rooms, this is 2000000000 + chatId.
        /// </summary>
        public long PeerId { get; }

        /// <summary>
        /// Gets the raw chat ID if the user is typing in a group chat, otherwise <c>null</c>.
        /// </summary>
        public long? ChatId { get; }

        /// <summary>
        /// Gets a value indicating whether the user is recording an audio/voice message.
        /// </summary>
        public bool IsAudioMessage { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTypingEventArgs"/> class.
        /// </summary>
        /// <param name="userId">The ID of the user who is typing.</param>
        /// <param name="peerId">The peer ID of the conversation.</param>
        /// <param name="chatId">The optional chat ID.</param>
        /// <param name="isAudioMessage">True if the user is recording an audio message, false if typing.</param>
        public UserTypingEventArgs(long userId, long peerId, long? chatId = null, bool isAudioMessage = false)
        {
            UserId = userId;
            PeerId = peerId;
            ChatId = chatId;
            IsAudioMessage = isAudioMessage;
        }
    }
}
