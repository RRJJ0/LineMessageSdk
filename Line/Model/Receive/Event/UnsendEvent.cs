using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Event
{
    public class UnsendEvent : Event
    {
        public Unsend unsend { get; set; }
    }

    public class Unsend
    {
        public string messageId { get; set; }
    }
}
