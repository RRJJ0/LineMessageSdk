using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message.Component
{
    public class Box : Component, HeroComponent
    {
        public override string type => "box";
        public string layout {  get; set; }
        public List<Component> contents { get; set; }
        public string? backgroundColor { get; set; }
        public string? borderColor { get; set; }
        public string? borderWidth { get; set; }
        public string? cornerRadius { get; set; }
        public string? width { get; set; }
        public string? maxWidth { get; set; }
        public string? height { get; set; }
        public string? maxHeight { get; set; }
        public int? flex { get; set; }
        public string? spacing { get; set; }
        public string? margin { get; set; }
        public string? paddingAll { get; set; }
        public string? paddingTop { get; set; }
        public string? paddingBottom { get; set; }
        public string? paddingStart { get; set; }
        public string? paddingEnd { get; set; }
        public string? position { get; set; }
        public string? offsetTop { get; set; }
        public string? offsetBottom { get; set; }
        public string? offsetStart { get; set; }
        public Action.Action? action { get; set; }
        public string? justifyContent { get; set; }
        public string? alignItems { get; set; }
        public Background? background { get; set; }

        public class Background
        {
            public string? type { get; set; }
            public string? angle { get; set; }
            public string? startColor { get; set; }
            public string? endColor { get; set; }
            public string? centerColor { get; set; }
            public string? centerPosition { get; set; }
        } 
    }
}
