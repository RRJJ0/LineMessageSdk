﻿using Line.Model.MessageAPI.Parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Content
{
    public class GetContent
    {
        public class Path : PathParam
        {
            [PathSequence(0)]
            public string messageId { get; set; }
        }
    }
}
