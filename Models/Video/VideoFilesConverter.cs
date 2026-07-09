using Newtonsoft.Json;
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

            return serializer.Deserialize<VideoFiles>(reader);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
