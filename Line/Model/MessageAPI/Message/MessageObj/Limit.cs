
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj
{
    public class Limit
    {
        public int max {  get; set; }

        public bool upToRemainingQuota {  get; set; }
    }
}
