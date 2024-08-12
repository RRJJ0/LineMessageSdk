using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj
{
    public class VideoMessage : ImageMessage
    {
        public override string type => "video";
        public string? trackingId { get; set; }
    }
}
