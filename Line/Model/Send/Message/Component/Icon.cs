using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message.Component
{
    public class Icon : Component
    {
        public override string type => "icon";
        public string url { get; set; }
        public string? margin { get; set; } 
        public string? position { get; set; } 
        public string? offsetTop { get; set; } 
        public string? offsetBottom { get; set; } 
        public string? offsetStart { get; set; } 
        public string? offsetEnd { get; set; } 
        public string? size { get; set; } 
        public bool? scaling { get; set; } 
        public string? aspectRatio { get; set; }  
    }
}
