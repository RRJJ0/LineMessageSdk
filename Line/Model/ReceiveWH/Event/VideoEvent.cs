using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Event
{
    public class VideoEvent : Event
    {
        public VideoPlayComplete videoPlayComplete { get; set; }
    }

    public class VideoPlayComplete
    {
        public string trackingId { get; set; }
    }
}
