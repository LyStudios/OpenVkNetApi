using Newtonsoft.Json;
using OpenVkNetApi.Models.Attachments;
using OpenVkNetApi.Models.Photos;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Video
{
    /// <summary>
    /// Represents a video object.
    /// </summary>
    public class Video
    {
        [JsonProperty("can_comment")]
        public int? CanComment { get; set; }

        [JsonProperty("can_like")]
        public int? CanLike { get; set; }

        [JsonProperty("can_repost")]
        public int? CanRepost { get; set; }

        [JsonProperty("can_subscribe")]
        public int? CanSubscribe { get; set; }

        [JsonProperty("can_add_to_faves")]
        public int? CanAddToFaves { get; set; }

        [JsonProperty("can_add")]
        public int? CanAdd { get; set; }

        [JsonProperty("image")]
        public List<PhotoSize>? Image { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

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

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// The video title.
        /// </summary>
        [JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The video description.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("is_favorite")]
        public bool? IsFavorite { get; set; }

        [JsonProperty("files")]
        public VideoFiles? Files { get; set; }

        [JsonProperty("platform")]
        public object? Platform { get; set; }

        [JsonProperty("added")]
        public int? Added { get; set; }

        [JsonProperty("repeat")]
        public int? Repeat { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("is_processed")]
        public bool? IsProcessed { get; set; }

        [JsonProperty("reposts")]
        public Reposts? Reposts { get; set; }

        [JsonProperty("likes")]
        public Attachments.Likes? Likes { get; set; }

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
        public string? Player { get; set; }

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
        public string? Photo130 { get; set; }

        /// <summary>
        /// URL of the 320px wide video thumbnail.
        /// </summary>
        [JsonProperty("photo_320")]
        public string? Photo320 { get; set; }

        /// <summary>
        /// URL of the 800px wide video thumbnail.
        /// </summary>
        [JsonProperty("photo_800")]
        public string? Photo800 { get; set; }
    }
}
