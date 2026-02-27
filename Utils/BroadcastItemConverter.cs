using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenVkNetApi.Models.Audio;
using System;

namespace OpenVkNetApi.Utils
{
    public sealed class BroadcastItemConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
            => objectType == typeof(BroadcastItem);

        public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
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

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
