using Line.Model.MessageAPI.Parameter;
using Line.Model.Receive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message
{
    public class Push
    {
        public class Body : BodyParam
        {
            public string to { get; set; }

            public List<MessageObj.Message> messages { get; set; }

            public bool? notificationDisabled { get; set; }

            public List<string>? customAggregationUnits { get; set; }
        }

        public class Response : Reply.Response
        {

        }
    }
}
