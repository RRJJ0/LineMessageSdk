﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Message
{
    public class Message
    {
        public string id { get; set; }
        public string type { get; set; }
        public string? quoteToken { get; set; }
    } 
}
