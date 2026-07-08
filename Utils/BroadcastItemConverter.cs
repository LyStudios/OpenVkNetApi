using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenVkNetApi.Models.Audio;
using System;

namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// Custom JSON converter for deserializing polymorphic <see cref="BroadcastItem"/> objects.
    /// Determines whether the item is a user or a group based on the JSON properties present.
    /// </summary>
    public sealed class BroadcastItemConverter : JsonConverter
    {
        /// <summary>
        /// Determines whether this converter can convert the specified object type.
        /// </summary>
        /// <param name="objectType">The type of the object to convert.</param>
        /// <returns><c>true</c> if the type is <see cref="BroadcastItem"/>; otherwise, <c>false</c>.</returns>
        public override bool CanConvert(Type objectType)
            => objectType == typeof(BroadcastItem);

        /// <summary>
        /// Reads the JSON representation of the broadcast item and instantiates the correct subclass (User or Group).
        /// </summary>
        /// <param name="reader">The JSON reader to read from.</param>
        /// <param name="objectType">The target object type.</param>
        /// <param name="existingValue">The existing value of the object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>A deserialized <see cref="BroadcastItem"/> object.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jo = JObject.Load(reader);

            BroadcastItem target;

            if (jo["first_name"] != null)
            {
                target = new BroadcastUser();
            }
            else if (jo["type"] != null)
            {
                target = new BroadcastGroup();
            }
            else
            {
                throw new JsonSerializationException("Unknown broadcast item type.");
            }

            serializer.Populate(jo.CreateReader(), target);
            return target;
        }

        /// <summary>
        /// Writes the JSON representation of the broadcast item.
        /// </summary>
        /// <param name="writer">The JSON writer to write to.</param>
        /// <param name="value">The broadcast item value to serialize.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
