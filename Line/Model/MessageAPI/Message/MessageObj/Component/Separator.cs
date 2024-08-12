using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj.Component
{
    public class Separator : Component
    {
        public override string type => "separator";
        public string? margin { get; set; }
        public string? color { get; set; }
    }
}
