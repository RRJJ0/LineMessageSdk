using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message
{

    public class LocationMessage : Message
    {
        public override string type => "location";
        public string title { get; set; }
        public string address { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
    }

}
