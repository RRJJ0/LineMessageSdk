using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message.Component
{
    public class Separator : Component
    {
        public override string type => "separator";
        public string? margin {  get; set; }
        public string? color {  get; set; }
    }
}
