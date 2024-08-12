using Line.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Message
{
    public class FileMessage : Message
    {
        public string fileName { get; set; }
        public string fileSize { get; set; }
    }
}
