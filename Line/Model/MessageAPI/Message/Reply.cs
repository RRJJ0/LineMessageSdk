using Line.Model.MessageAPI.Parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message
{
    public class Reply
    {
        public class Body : BodyParam
        {
            public string replyToken { get; set; }

            public List<MessageObj.Message> messages { get; set; }

            public bool? notificationDisabled { get; set; }

        }

        public class Response
        {

            public List<SendMsg> sentMessages { get; set; }

            public class SendMsg
            {
                public string id { get; set; }
                public string quoteToken { get; set; }
            }
        }
    }
}
