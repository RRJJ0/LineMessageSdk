using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message.Action
{
    public class MessageAction : Action
    {
        public override string type => "message";
        public string? label { get; set; }
        public string text { get; set; }
    }
}
