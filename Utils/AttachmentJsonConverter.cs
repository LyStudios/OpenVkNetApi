using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenVkNetApi.Models.Attachments;
using System;
using System.Collections.Generic;

namespace OpenVkNetApi.Utils
{
    public class AttachmentJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(List<Attachment>);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var list = value as List<Attachment>;
            if (list == null)
            {
                writer.WriteNull();
                return;
            }

            var array = new JArray();

            foreach (var att in list)
            {
                JToken payload = null;
                switch (att)
                {
                    case PhotoAttachment photo:
                        payload = photo.Photo != null ? JToken.FromObject(photo.Photo, serializer) : null;
                        break;
                    case VideoAttachment video:
                        payload = video.Video != null ? JToken.FromObject(video.Video, serializer) : null;
                        break;
                    case AudioAttachment audio:
                        payload = audio.Audio != null ? JToken.FromObject(audio.Audio, serializer) : null;
                        break;
                    case DocumentAttachment doc:
                        payload = doc.Document != null ? JToken.FromObject(doc.Document, serializer) : null;
                        break;
                    case NoteAttachment note:
                        payload = note.Note != null ? JToken.FromObject(note.Note, serializer) : null;
                        break;
                    case PollAttachment poll:
                        payload = poll.Poll != null ? JToken.FromObject(poll.Poll, serializer) : null;
                        break;
                    case UnknownAttachment unknown:
                        payload = unknown.Raw?[att.Type];
                        break;
                }

                var obj = new JObject
                {
                    ["type"] = att.Type,
                    [att.Type] = payload
                };
                array.Add(obj);
            }

            array.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartArray) return new List<Attachment>();

            var array = JArray.Load(reader);
            var result = new List<Attachment>();

            foreach (var token in array)
            {
                var type = token["type"]?.ToString();
                if (type == null) continue;

                Attachment attachment = null;
                switch (type)
                {
                    case "photo":
                        var photoAtt = new PhotoAttachment { Type = "photo" };
                        photoAtt.Photo = token["photo"]?.ToObject<OpenVkNetApi.Models.Photos.Photo>(serializer);
                        attachment = photoAtt;
                        break;
                    case "video":
                        var videoAtt = new VideoAttachment { Type = "video" };
                        videoAtt.Video = token["video"]?.ToObject<OpenVkNetApi.Models.Video.Video>(serializer);
                        attachment = videoAtt;
                        break;
                    case "doc":
                        var docAtt = new DocumentAttachment { Type = "doc" };
                        docAtt.Document = token["doc"]?.ToObject<OpenVkNetApi.Models.Docs.Doc>(serializer);
                        attachment = docAtt;
                        break;
                    case "audio":
                        var audioAtt = new AudioAttachment { Type = "audio" };
                        audioAtt.Audio = token["audio"]?.ToObject<OpenVkNetApi.Models.Audio.Audio>(serializer);
                        attachment = audioAtt;
                        break;
                    case "note":
                        var noteAtt = new NoteAttachment { Type = "note" };
                        noteAtt.Note = token["note"]?.ToObject<OpenVkNetApi.Models.Notes.Note>(serializer);
                        attachment = noteAtt;
                        break;
                    case "poll":
                        var pollAtt = new PollAttachment { Type = "poll" };
                        pollAtt.Poll = token["poll"]?.ToObject<OpenVkNetApi.Models.Polls.Poll>(serializer);
                        attachment = pollAtt;
                        break;
                    default:
                        attachment = new UnknownAttachment { Type = type, Raw = (JObject)token };
                        break;
                }

                if (attachment != null)
                    result.Add(attachment);
            }

            return result;
        }
    }
}
