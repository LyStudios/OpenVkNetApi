using Newtonsoft.Json;
using System;

namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// Converts integer values (1/0) or strings ("1"/"0") from JSON into C# boolean values (true/false) and vice versa.
    /// </summary>
    public class BoolToIntConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(bool) || objectType == typeof(bool?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return objectType == typeof(bool?) ? (bool?)null : false;
            }

            if (reader.TokenType == JsonToken.Integer || reader.TokenType == JsonToken.Float)
            {
                var val = Convert.ToInt64(reader.Value);
                return val != 0;
            }

            if (reader.TokenType == JsonToken.Boolean)
            {
                return (bool)reader.Value;
            }

            if (reader.TokenType == JsonToken.String)
            {
                var str = (string)reader.Value;
                if (int.TryParse(str, out int val))
                {
                    return val != 0;
                }
                if (bool.TryParse(str, out bool bVal))
                {
                    return bVal;
                }
            }

            return false;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue((bool)value ? 1 : 0);
            }
        }
    }
}
