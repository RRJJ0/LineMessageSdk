using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message
{
    public class StickerMessage : Message
    {
        public override string type => "sticker";
        public string packageId { get; set; }
        public string stickerId { get; set; }
        public string? quoteToken { get; set; }
    }
}
