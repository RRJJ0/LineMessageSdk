using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj.Component
{
    public class Span : Component
    {
        public override string type => "span";
        public string? text { get; set; }
        public string? color { get; set; }
        public string? size { get; set; }
        public string? weight { get; set; }
        public string? style { get; set; }
        public string? decoration { get; set; }
    }
}
