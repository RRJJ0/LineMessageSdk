using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message.Action
{
    public class PostbackAction : Action
    {
        public override string type => "postback";
        public string? label { get; set; }
        public string data { get; set; }
        public string? displayText { get; set; }
        public string? text { get; set; }
        public string? inputOption { get; set; }
        public string? fillInText { get; set; }
    }
}
