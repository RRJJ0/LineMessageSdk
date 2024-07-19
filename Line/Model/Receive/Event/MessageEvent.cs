using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Event
{
    public class MessageEvent : Event
    {
        public object message { get; set; }
    }
}
