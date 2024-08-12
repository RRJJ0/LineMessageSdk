using Line.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Message
{
    public class TextMessage : Message
    {
        public string text { get; set; }
        public List<Emojit>? emojis { get; set; }
        public Mention? mention { get; set; }
        public string? quotedMessageId { get; set; }
    }


    public class Emojit
    {
        public int index { get; set; }
        public int length { get; set; }
        public string productId { get; set; }
        public string emojiId { get; set; }
    }

    public class Mention
    {
        public List<Mentionees> mentionees { get; set; }
    }

    public class Mentionees
    {
        public int index { get; set; }
        public int length { get; set; }
        public string type { get; set; }
        public string? userId { get; set; }
    }

}
