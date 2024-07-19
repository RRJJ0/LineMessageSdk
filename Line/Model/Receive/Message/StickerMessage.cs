using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Message
{
    public class StickerMessage
    {
        public string packageId { get; set; }
        public string stickerId { get; set; }
        public string stickerResourceType { get; set; }
        public string? text { get; set; }
        public string? quotedMessageId { get; set; }
        public List<string>? keywords { get; set; }
    }
}
