using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj
{
    public abstract class Message
    {
        public abstract string type { get; }
    }
}
