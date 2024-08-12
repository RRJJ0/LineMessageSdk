using Line.Model.MessageAPI.Parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message
{
    public class Multicast
    {
        public class Body : BodyParam
        {
            public List<string> to { get; set; }

            public List<MessageObj.Message> messages { get; set; }

            public bool? notificationDisabled { get; set; }

            public List<string>? customAggregationUnits { get; set; }
        }
    }
}
