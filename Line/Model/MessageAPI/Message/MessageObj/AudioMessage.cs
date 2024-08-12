using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj
{
    public class AudioMessage : Message
    {
        public override string type => "audio";
        public string originalContentUrl { get; set; }
        public int duration { get; set; } // Length of audio file (milliseconds)
    }

}
