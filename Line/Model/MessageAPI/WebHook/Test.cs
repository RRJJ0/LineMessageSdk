using Line.Model.MessageAPI.Parameter;
using Line.Model.Receive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.WebHook
{
    public class Test
    {
        public class Body : BodyParam
        {
            public string endpoint { get; set; }
        }

        public class Response 
        { 
            public bool success { get; set; }
            public string timestamp { get; set; }
            public int statusCode { get; set; }
            public string reason { get; set; }
            public string detail { get; set; }
        }
    }
}
