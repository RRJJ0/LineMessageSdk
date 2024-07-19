using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message.Component
{
    public class Text : Component
    {
        public override string type => "text";
        public string? text { get; set; }
        public List<Span>? contents { get; set; }
        public string? adjustMode { get; set; }
        public int? flex { get; set; }
        public string? margin { get; set; }
        public string? position { get; set; }
        public string? offsetTop { get; set; }
        public string? offsetBottom { get; set; }
        public string? offsetStart { get; set; }
        public string? offsetEnd { get; set; }
        public string? size { get; set; }
        public bool? scaling { get; set; }
        public string? align { get; set; }
        public string? gravity { get; set; }
        public bool? wrap { get; set; }
        public string? lineSpacing { get; set; }
        public int? maxLines { get; set; }
        public string? weight { get; set; }
        public string? color { get; set; }
        public Action.Action? action { get; set; }
        public string? style { get; set;}
        public string? decoration { get; set;}
    }
}
