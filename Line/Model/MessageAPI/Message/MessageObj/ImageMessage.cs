﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj
{
    public class ImageMessage : Message
    {
        public override string type => "image";
        public string originalContentUrl { get; set; }
        public string previewImageUrl { get; set; }
    }
}
