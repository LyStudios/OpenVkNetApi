using Newtonsoft.Json;
using System;

namespace OpenVkNetApi.Models.Audio
{
    /// <summary>
    /// Handles cases where the OpenVK API returns `false` (boolean) 
    /// instead of an `AudioKeys` object when keys are unavailable/invalid.
    /// </summary>
    public sealed class AudioKeysConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(AudioKeys);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Boolean)
            {
                // Consume the boolean value (e.g. false)
                return null;
            }

            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var keys = new AudioKeys();
            serializer.Populate(reader, keys);
            return keys;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
