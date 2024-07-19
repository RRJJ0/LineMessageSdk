using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive
{
    public static class EventType
    {
        public const string Message = "message";
        public const string Unsend = "unsend";
        public const string Follow = "follow";
        public const string UnFollow = "unfollow";
        public const string Join = "join";
        public const string Leave = "leave";
        public const string MemberJoined = "memberJoined";
        public const string MemberLeft = "memberLeft";
        public const string PostBack = "postback";
        public const string VideoPlayComplete = "videoPlayComplete";
        public const string Beacon = "beacon";
        public const string AccountLink = "accountLink";
    }

    public static class MsgType
    {
        public const string Text = "text";
        public const string Sticker = "sticker";
        public const string Image = "image";
        public const string Video = "video";
        public const string Audio = "audio";
        public const string Location = "location";
        public const string File = "file";
    }

    public class Body
    {
        public string destination { get; set; }
        public List<object> events { get; set; }
    } 
}
