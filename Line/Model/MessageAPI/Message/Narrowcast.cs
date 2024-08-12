using Line.Model.MessageAPI.Message.MessageObj;
using Line.Model.MessageAPI.Parameter;
using Line.Model.Receive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message
{
    public class Narrowcast
    {
        public class Body : BodyParam
        {
            public List<MessageObj.Message> messages { get; set; }

            public Recipient recipient { get; set; }

            public Filter filter { get; set; }

            public Limit limit { get; set; }

            public bool? notificationDisabled { get; set; }
        }
    }
}
