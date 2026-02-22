using System.IO;

namespace OpenVkNetApi.Models.Photos
{
    /// <summary>
    /// Represents a photo that is pending upload.
    /// Holds the photo stream and file name until it is uploaded.
    /// </summary>
    internal sealed class PendingPhoto
    {
        /// <summary>
        /// The stream containing the photo data.
        /// </summary>
        public Stream Stream { get; }

        /// <summary>
        /// The name of the photo file (e.g., "image.jpg").
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingPhoto"/> class.
        /// </summary>
        /// <param name="stream">The stream containing the photo data.</param>
        /// <param name="fileName">The name of the photo file.</param>
        public PendingPhoto(Stream stream, string fileName)
        {
            Stream = stream;
            FileName = fileName;
        }
    }
}
