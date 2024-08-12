using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Body
{
    public class MulticastBody : Body
    {
        public List<string> to {  get; set; }
        public List<string>? customAggregationUnits { get; set; }
    }
}
