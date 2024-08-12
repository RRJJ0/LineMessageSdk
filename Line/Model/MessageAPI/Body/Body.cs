using Line.Model.Receive;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Body
{
    public class Body
    {

        public List<MessageAPI.Message.MessageObj.Message> messages { get; set; }
        public bool? notificationDisabled { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }


    public class BodyType
    {
        public const string Reply = "reply";
        public const string Push = "push";
        public const string Multicast = "multicast";
        public const string Broadcast = "broadcast";
        public const string Narrowcast = "narrowcast";
    }
}
