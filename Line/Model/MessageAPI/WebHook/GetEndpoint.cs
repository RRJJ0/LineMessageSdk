using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.WebHook
{
    public class GetEndpoint
    {
        public class Response
        {
            public string endpoint {  get; set; }
            public bool active { get; set; }
        }
    }
}
