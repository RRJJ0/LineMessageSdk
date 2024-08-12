using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj
{
    public class TextMessage : Message
    {

        public override string type => "text";
        public string text { get; set; }
        public List<Emojit>? emojis { get; set; }
        public string? quoteToken { get; set; }

        public class Emojit
        {
            public int index { get; set; }
            public string productId { get; set; }
            public string emojiId { get; set; }
        }
    }


}
