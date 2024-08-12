using Line.Model.MessageAPI.Parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.WebHook
{
    public class PutEndpoint
    {
        public class Body: BodyParam
        {
            public string endpoint {  get; set; }
        }
    }
}
