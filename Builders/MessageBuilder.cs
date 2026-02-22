using OpenVkNetApi.Methods;
using OpenVkNetApi.Models.Photos;
using OpenVkNetApi.Models.RequestParameters.Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace OpenVkNetApi.Builders
{
    /// <summary>
    /// Provides a fluent API for constructing and sending messages
    /// through the <c>messages.send</c> method of the OpenVK API.
    /// </summary>
    /// <remarks>
    /// This builder allows setting recipient information, message text,
    /// attachments, and uploading photos before sending the message.
    /// </remarks>
    public sealed class MessageBuilder
    {
        /// <summary>
        /// Provides access to the messages API methods.
        /// </summary>
        private readonly Messages _messages;

        /// <summary>
        /// Provides access to photo upload methods.
        /// </summary>
        private readonly Photos _photosApi;

        /// <summary>
        /// The target user identifier.
        /// </summary>
        private int _userId;

        /// <summary>
        /// The target peer identifier.
        /// </summary>
        private int _peerId;

        /// <summary>
        /// The message text content.
        /// </summary>
        private string _message = "";

        /// <summary>
        /// A collection of attachment strings formatted for API usage.
        /// </summary>
        private readonly List<string> _attachments = new List<string>();

        /// <summary>
        /// A collection of photos pending upload.
        /// </summary>
        private readonly List<PendingPhoto> _photos = new List<PendingPhoto>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBuilder"/> class.
        /// </summary>
        /// <param name="messages">An instance of the messages API methods.</param>
        /// <param name="photosApi">An instance of the photos API methods.</param>
        internal MessageBuilder(Messages messages, Photos photosApi)
        {
            _messages = messages;
            _photosApi = photosApi;
        }

        /// <summary>
        /// Specifies the recipient by user identifier.
        /// </summary>
        /// <param name="userId">The identifier of the target user.</param>
        /// <returns>The current <see cref="MessageBuilder"/> instance.</returns>
        public MessageBuilder ToUser(int userId)
        {
            _userId = userId;
            _peerId = -1;
            return this;
        }

        /// <summary>
        /// Specifies the recipient by peer identifier.
        /// </summary>
        /// <param name="peerId">
        /// The peer identifier (user, chat or community).
        /// </param>
        /// <returns>The current <see cref="MessageBuilder"/> instance.</returns>
        public MessageBuilder ToPeer(int peerId)
        {
            _peerId = peerId;
            _userId = -1;
            return this;
        }

        /// <summary>
        /// Sets the message text.
        /// </summary>
        /// <param name="message">The text content of the message.</param>
        /// <returns>The current <see cref="MessageBuilder"/> instance.</returns>
        public MessageBuilder WithText(string message)
        {
            _message = message;
            return this;
        }

        /// <summary>
        /// Adds a photo that will be uploaded and attached to the message.
        /// </summary>
        /// <param name="stream">The stream containing photo data.</param>
        /// <param name="fileName">The file name of the photo.</param>
        /// <returns>The current <see cref="MessageBuilder"/> instance.</returns>
        public MessageBuilder AddPhoto(Stream stream, string fileName)
        {
            _photos.Add(new PendingPhoto(stream, fileName));
            return this;
        }

        /// <summary>
        /// Attaches an already uploaded media object.
        /// </summary>
        /// <param name="type">
        /// The media type (for example: photo, video, audio, doc, sticker).
        /// </param>
        /// <param name="ownerId">The owner identifier of the media.</param>
        /// <param name="mediaId">The identifier of the media object.</param>
        /// <returns>The current <see cref="MessageBuilder"/> instance.</returns>
        public MessageBuilder Attach(string type, int ownerId, int mediaId)
        {
            _attachments.Add($"{type}{ownerId}_{mediaId}");
            return this;
        }

        /// <summary>
        /// Uploads pending photos (if any) and sends the constructed message.
        /// </summary>
        /// <param name="ct">
        /// A cancellation token that can be used to cancel the operation.
        /// </param>
        /// <returns>
        /// A list of identifiers of the sent messages.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if no recipient has been specified.
        /// </exception>
        public async Task<List<int>> SendAsync(CancellationToken ct = default)
        {
            if (_userId == -1 && _peerId == -1)
                throw new InvalidOperationException("Recipient is not specified.");

            foreach (var photo in _photos)
            {
                var uploaded = await _photosApi
                    .UploadMessagePhotoAsync(photo.Stream, photo.FileName, ct);

                if (uploaded?.Items != null)
                {
                    foreach (var p in uploaded.Items)
                        _attachments.Add($"photo{p.OwnerId}_{p.Id}");
                }
            }

            var sendParams = new MessagesSendParams
            {
                UserId = _userId,
                PeerId = _peerId,
                Message = _message,
                Attachment = _attachments.Count > 0
                    ? string.Join(",", _attachments)
                    : ""
            };

            return await _messages.SendAsync(sendParams, ct);
        }
    }
}
