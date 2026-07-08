using Newtonsoft.Json;
using System;

namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// Converts integer values (1/0) or strings ("1"/"0") from JSON into C# boolean values (true/false) and vice versa.
    /// </summary>
    public class BoolToIntConverter : JsonConverter
    {
        /// <summary>
        /// Determines whether this converter can convert the specified object type.
        /// </summary>
        /// <param name="objectType">The type of the object to convert.</param>
        /// <returns><c>true</c> if the type is a boolean or nullable boolean; otherwise, <c>false</c>.</returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(bool) || objectType == typeof(bool?);
        }

        /// <summary>
        /// Reads the JSON representation of the boolean value, converting 1/0 or "1"/"0" to C# boolean.
        /// </summary>
        /// <param name="reader">The JSON reader to read from.</param>
        /// <param name="objectType">The target object type.</param>
        /// <param name="existingValue">The existing value of the object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The deserialized boolean value.</returns>
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

        /// <summary>
        /// Writes the JSON representation of the boolean value as 1 or 0.
        /// </summary>
        /// <param name="writer">The JSON writer to write to.</param>
        /// <param name="value">The boolean value to serialize.</param>
        /// <param name="serializer">The calling serializer.</param>
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
