using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message.Component
{
    public class Video : Component, HeroComponent
    {
        public override string type => "video";
        public string url { get; set; }
        public string previewUrl { get; set; }
        public Component altContent { get; set; }
        public string? aspectRatio { get; set; }
        public Action.Action? action { get; set; }
    }
}
