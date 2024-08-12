using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj.Action
{
    public class RichMenuSwitchAction : Action
    {
        public override string type => "richmenuswitch";
        public string? label { get; set; }
        public string richMenuAliasId { get; set; }
        public string data { get; set; }
    }
}
