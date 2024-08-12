using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Message
{
    public class VideoMessage
    {
        public long? duration { get; set; }
        public MediaProvider contentProvider { get; set; }
    }
}
