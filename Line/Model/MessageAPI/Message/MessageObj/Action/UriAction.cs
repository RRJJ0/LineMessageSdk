using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj.Action
{
    public class UriAction : Action
    {
        public override string type => "uri";
        public string? label { get; set; }
        public string uri { get; set; }
        public AltUri? altUri { get; set; }

        public class AltUri
        {
            public string desktop { get; set; }
        }
    }
}
