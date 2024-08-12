using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Content
{
    public class Transcoding
    {
        public class Path : GetContent.Path
        {

        }

        public class Response
        {
            public string status { get; set; }
    }
}
