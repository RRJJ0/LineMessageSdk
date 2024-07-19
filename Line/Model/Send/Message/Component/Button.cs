using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message.Component
{
    public class Button : Component
    {
        public override string type => "button";
        public Action.Action action {  get; set; }
        public int? flex { get; set; }
        public string? margin { get; set; }
        public string? position { get; set; }
        public string? offsetTop { get; set; }
        public string? offsetBottom { get; set; }
        public string? offsetStart { get; set; }
        public string? offsetEnd { get; set; }
        public string? height { get; set; }
        public string? style { get; set; }
        public string? color { get; set; }
        public string? gravity { get; set; }
        public string? adjustMode { get; set; }
        public bool? scaling { get; set; }
    }
}
