using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Event
{
    public class MemberLeftEvent : Event
    {
        public MemberAction left { get; set; }
    }
}
