using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace OpenVkNetApi.Models.Video
{
    /// <summary>
    /// Handles cases where the OpenVK API returns an empty array `[]` 
    /// instead of a `VideoFiles` object `{}` when video files are unavailable/processing.
    /// </summary>
    public sealed class VideoFilesConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(VideoFiles);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartArray)
            {
                // Consume the empty array []
                while (reader.Read() && reader.TokenType != JsonToken.EndArray) { }
                return null;
            }

            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            // Load JObject to bypass the serializer circular dependency loop
            var obj = JObject.Load(reader);
            var files = new VideoFiles
            {
                Mp4480 = obj["mp4_480"]?.Value<string>()
            };
            return files;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }

            var files = (VideoFiles)value;
            writer.WriteStartObject();
            writer.WritePropertyName("mp4_480");
            writer.WriteValue(files.Mp4480);
            writer.WriteEndObject();
        }
    }
}
