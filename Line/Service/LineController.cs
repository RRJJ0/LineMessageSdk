using Line.Model.Receive;
using Line.Model.Receive.Event;
using Line.Model.Receive.Message;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json; 
using System.Security.Cryptography;
using System.Text; 

namespace Line.Service
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class LineController(IMessageReceiver receiver) : ControllerBase
    {
        private readonly IMessageReceiver receiver = receiver;

        [HttpPost]
        public async Task<ActionResult> ReceiveAsync()
        {
            if (!Request.Headers.TryGetValue("X-Line-Signature", out StringValues xLineSignature))
            {
                return Unauthorized();
            }
            string requestBody = string.Empty;
            using (var reader = new StreamReader(Request.Body))
            {
                requestBody = await reader.ReadToEndAsync();
            }
            if (!VerifySignature(requestBody, xLineSignature.ToString()))
            {
                return Unauthorized();
            }

            var body = JsonConvert.DeserializeObject<Body>(requestBody);
            if (body != null && receiver != null)
            {
                foreach (var obj in body.events)
                {
                    JObject eventJo = JObject.Parse(obj.ToString()!);
                    var eventType = eventJo["type"]?.ToString();
                    if (eventType == EventType.Message)
                    {
                        var it = eventJo.ToObject<MessageEvent>()!;
                        JObject jo = JObject.Parse(it.message!.ToString()!);
                        var type = jo["type"]?.ToString();
                        if (type == MsgType.Text)
                        {
                            var msg = jo.ToObject<TextMessage>();
                            receiver.OnTextMessage(it, msg!);
                        }
                        else if (type == MsgType.Image)
                        {
                            var msg = jo.ToObject<ImageMessage>();
                            receiver.OnImageMessage(it, msg!);
                        }
                        else if (type == MsgType.Video)
                        {
                            var msg = jo.ToObject<VideoMessage>();
                            receiver.OnVideoMessage(it, msg!);
                        }
                        else if (type == MsgType.Audio)
                        {
                            var msg = jo.ToObject<VideoMessage>();
                            receiver.OnAudioMessage(it, msg!);
                        }
                        else if (type == MsgType.File)
                        {
                            var msg = jo.ToObject<FileMessage>();
                            receiver.OnFileMessage(it, msg!);
                        }
                        else if (type == MsgType.Location)
                        {
                            var msg = jo.ToObject<LocationMessage>();
                            receiver.OnLocationMessage(it, msg!);
                        }
                        else if (type == MsgType.Sticker)
                        {
                            var msg = jo.ToObject<StickerMessage>();
                            receiver.OnStickerMessage(it, msg!);
                        }
                    }
                    else if (eventType == EventType.Unsend)
                    {
                        var it = eventJo.ToObject<UnsendEvent>()!;
                        receiver.OnUnsend(it);
                    }
                    else if (eventType == EventType.Follow)
                    {
                        var it = eventJo.ToObject<FollowEvent>()!;
                        receiver.OnFollow(it);
                    }
                    else if (eventType == EventType.UnFollow)
                    {
                        var it = eventJo.ToObject<Event>()!;
                        receiver.OnUnFollow(it);
                    }
                    else if (eventType == EventType.Join)
                    {
                        var it = eventJo.ToObject<Event>()!;
                        receiver.OnJoin(it);
                    }
                    else if (eventType == EventType.Leave)
                    {
                        var it = eventJo.ToObject<Event>()!;
                        receiver.OnLeave(it);
                    }
                    else if (eventType == EventType.MemberJoined)
                    {
                        var it = eventJo.ToObject<MemberJoinEvent>()!;
                        receiver.OnMemberJoin(it);
                    }
                    else if (eventType == EventType.MemberLeft)
                    {
                        var it = eventJo.ToObject<MemberLeftEvent>()!;
                        receiver.OnMemberLeave(it);
                    }
                    else if (eventType == EventType.PostBack)
                    {
                        var it = eventJo.ToObject<PostBackEvent>()!;
                        receiver.OnPoseBack(it);
                    }
                    else if (eventType == EventType.VideoPlayComplete)
                    {
                        var it = eventJo.ToObject<VideoEvent>()!;
                        receiver.OnVideoEnd(it);
                    }
                    else if (eventType == EventType.Beacon)
                    {
                        var it = eventJo.ToObject<BeaconEvent>()!;
                        receiver.OnBeacon(it);
                    }
                    else if (eventType == EventType.AccountLink)
                    {
                        var it = eventJo.ToObject<AccountLinkEvent>()!;
                        receiver.OnAccountLink(it);
                    }
                }
            }

            return Ok();
        }

        private bool VerifySignature(string requestBody, string xLineSignature)
        {
            byte[] key = Encoding.UTF8.GetBytes(receiver.GetChannelSercet());
            byte[] message = Encoding.UTF8.GetBytes(requestBody);
            using var hmac = new HMACSHA256(key);
            byte[] hash = hmac.ComputeHash(message); 
            return Convert.ToBase64String(hash).Equals(xLineSignature);
        }
    }
}
