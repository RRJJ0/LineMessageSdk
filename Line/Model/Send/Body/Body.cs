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

        public List<Message.Message> messages { get; set; }
        public bool? notificationDisabled { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }


    public class BodyType
    {
        public const string push = "push";
        public const string multicast = "multicast";
        public const string broadcast = "broadcast";
    }
}
