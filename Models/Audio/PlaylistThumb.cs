using Newtonsoft.Json;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Represents the cover thumbnail metadata for an audio playlist/album.
    /// </summary>
    public class PlaylistThumb
    {
        /// <summary>
        /// Gets or sets the width of the cover image.
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the cover image.
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the URL of the 34x34px cover image.
        /// </summary>
        [JsonProperty("photo_34")]
        public string Photo34 { get; set; }

        /// <summary>
        /// Gets or sets the URL of the 68x68px cover image.
        /// </summary>
        [JsonProperty("photo_68")]
        public string Photo68 { get; set; }

        /// <summary>
        /// Gets or sets the URL of the 135x135px cover image.
        /// </summary>
        [JsonProperty("photo_135")]
        public string Photo135 { get; set; }

        /// <summary>
        /// Gets or sets the URL of the 270x270px cover image.
        /// </summary>
        [JsonProperty("photo_270")]
        public string Photo270 { get; set; }

        /// <summary>
        /// Gets or sets the URL of the 300x300px cover image.
        /// </summary>
        [JsonProperty("photo_300")]
        public string Photo300 { get; set; }

        /// <summary>
        /// Gets or sets the URL of the 600x600px cover image.
        /// </summary>
        [JsonProperty("photo_600")]
        public string Photo600 { get; set; }

        /// <summary>
        /// Gets or sets the URL of the 1200x1200px cover image.
        /// </summary>
        [JsonProperty("photo_1200")]
        public string Photo1200 { get; set; }
    }
}
