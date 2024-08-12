using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj.Action
{
    public class ClipboardAction : Action
    {
        public override string type => "clipboard";
        public string? label { get; set; }
        public string clipboardText { get; set; }
    }
}
