using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Parameter
{
    public class BodyParam
    {
        public override string ToString()
        {

            return JsonConvert.SerializeObject(this);
        }
    }
}
