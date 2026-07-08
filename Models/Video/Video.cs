using Newtonsoft.Json;
using OpenVkNetApi.Models.Photos;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Video
{
    /// <summary>
    /// Represents a video object.
    /// </summary>
    public class Video
    {
        /// <summary>
        /// Gets or sets a value indicating whether the current user can comment on this video.
        /// </summary>
        [JsonProperty("can_comment")]
        public int? CanComment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current user can like this video.
        /// </summary>
        [JsonProperty("can_like")]
        public int? CanLike { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current user can repost this video.
        /// </summary>
        [JsonProperty("can_repost")]
        public int? CanRepost { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current user can subscribe to the author of this video.
        /// </summary>
        [JsonProperty("can_subscribe")]
        public int? CanSubscribe { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current user can add this video to their favorites.
        /// </summary>
        [JsonProperty("can_add_to_faves")]
        public int? CanAddToFaves { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current user can add this video to their video list.
        /// </summary>
        [JsonProperty("can_add")]
        public int? CanAdd { get; set; }

        /// <summary>
        /// Gets or sets the list of video cover thumbnails in different sizes.
        /// </summary>
        [JsonProperty("image")]
        public List<PhotoSize> Image { get; set; }

        /// <summary>
        /// Gets or sets the width of the video in pixels.
        /// </summary>
        [JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the video in pixels.
        /// </summary>
        [JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The video ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The video owner's ID.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user who uploaded the video.
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// The video title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The video description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this video is added to the current user's favorites.
        /// </summary>
        [JsonProperty("is_favorite")]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Gets or sets the video files endpoints or URLs.
        /// </summary>
        [JsonProperty("files")]
        public VideoFiles Files { get; set; }

        /// <summary>
        /// Gets or sets the platform where the video is hosted or played.
        /// </summary>
        [JsonProperty("platform")]
        public object Platform { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this video is added to the user's video list (1 if added, 0 otherwise).
        /// </summary>
        [JsonProperty("added")]
        public int? Added { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the video should repeat playback.
        /// </summary>
        [JsonProperty("repeat")]
        public int? Repeat { get; set; }

        /// <summary>
        /// Gets or sets the type of the video (e.g., "video", "music_video").
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the video has been processed by the server and is ready for playback.
        /// </summary>
        [JsonProperty("is_processed")]
        public bool? IsProcessed { get; set; }

        /// <summary>
        /// Gets or sets information about the reposts of this video.
        /// </summary>
        [JsonProperty("reposts")]
        public RepostsInfo Reposts { get; set; }

        /// <summary>
        /// Gets or sets information about the likes on this video.
        /// </summary>
        [JsonProperty("likes")]
        public LikesInfo Likes { get; set; }

        /// <summary>
        /// The video duration in seconds.
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The date when the video was uploaded, in Unix time.
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }

        /// <summary>
        /// The URL of the video player.
        /// </summary>
        [JsonProperty("player")]
        public string Player { get; set; }

        /// <summary>
        /// The number of views the video has.
        /// </summary>
        [JsonProperty("views")]
        public int Views { get; set; }

        /// <summary>
        /// The number of comments on the video.
        /// </summary>
        [JsonProperty("comments")]
        public int Comments { get; set; }

        /// <summary>
        /// URL of the 130px wide video thumbnail.
        /// </summary>
        [JsonProperty("photo_130")]
        public string Photo130 { get; set; }

        /// <summary>
        /// URL of the 320px wide video thumbnail.
        /// </summary>
        [JsonProperty("photo_320")]
        public string Photo320 { get; set; }

        /// <summary>
        /// URL of the 800px wide video thumbnail.
        /// </summary>
        [JsonProperty("photo_800")]
        public string Photo800 { get; set; }
    }
}
