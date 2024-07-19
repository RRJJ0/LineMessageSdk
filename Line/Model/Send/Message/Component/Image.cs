using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message.Component
{
    public class Image : Component, HeroComponent
    {
        public override string type => "image";
        public string url { get; set; }
        public int? flex { get; set; }
        public string? margin { get; set; }
        public string? position { get; set; }
        public string? offsetTop { get; set; }
        public string? offsetBottom { get; set; }
        public string? offsetStart { get; set; }
        public string? offsetEnd { get; set; }
        public string? align { get; set; }
        public string? gravity { get; set; }
        public string? size { get; set; }
        public string? aspectRatio { get; set; }
        public string? aspectMode { get; set; }
        public string? backgroundColor { get; set; }
        public Action.Action? action { get; set; }
        public bool? animated { get; set; }
    }
}
