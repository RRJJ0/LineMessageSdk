using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj.Action
{
    public class CameraAction : Action
    {
        public override string type => "camera";
        public string label { get; set; }
    }
}
