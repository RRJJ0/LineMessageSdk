using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj.Action
{
    public class MessageAction : Action
    {
        public override string type => "message";
        public string? label { get; set; }
        public string text { get; set; }
    }
}
