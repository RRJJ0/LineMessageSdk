using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message.Action
{
    public class CameraAction : Action
    {
        public override string type => "camera";
        public string label { get; set; }
    }
}
