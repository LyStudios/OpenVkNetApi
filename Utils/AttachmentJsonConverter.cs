using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenVkNetApi.Models.Attachments;
using System;
using System.Collections.Generic;

namespace OpenVkNetApi.Utils
{
    public class AttachmentJsonConverter : JsonConverter<List<Attachment>>
    {
        public override void WriteJson(JsonWriter writer, List<Attachment>? value, JsonSerializer serializer)
        {
            var array = new JArray();

            foreach (var att in value!)
            {
                var obj = new JObject
                {
                    ["type"] = att.Type,
                    [att.Type] = JToken.FromObject(att, serializer)
                };
                array.Add(obj);
            }

            array.WriteTo(writer);
        }

        public override List<Attachment>? ReadJson(JsonReader reader, Type objectType, List<Attachment>? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartArray) return new List<Attachment>();

            var array = JArray.Load(reader);
            var result = new List<Attachment>();

            foreach (var token in array)
            {
                var type = token["type"]?.ToString();
                if (type == null) continue;

                Attachment? attachment = type switch
                {
                    "photo" => token["photo"]?.ToObject<PhotoAttachment>(serializer),
                    "video" => token["video"]?.ToObject<VideoAttachment>(serializer),
                    "doc" => token["doc"]?.ToObject<DocumentAttachment>(serializer),
                    "audio" => token["audio"]?.ToObject<AudioAttachment>(serializer),
                    "note" => token["note"]?.ToObject<NoteAttachment>(serializer),
                    "poll" => token["poll"]?.ToObject<PollAttachment>(serializer),
                    _ => new UnknownAttachment { Type = type, Raw = (JObject)token }
                };

                if (attachment != null)
                    result.Add(attachment);
            }

            return result;
        }
    }
}
