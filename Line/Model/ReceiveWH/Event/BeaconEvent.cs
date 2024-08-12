using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Event
{
    public class BeaconEvent : Event
    {
        public Beacon beacon { get; set; }
    }

    public class Beacon
    {
        public string type { get; set; }
        public string hwid { get; set; }
        public string? dm { get; set; }
    }
}
