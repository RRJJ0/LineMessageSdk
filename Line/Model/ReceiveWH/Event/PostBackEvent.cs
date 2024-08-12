using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Event
{
    public class PostBackEvent : Event
    {
        public PostBack postback { get; set; }
    }

    public class PostBack
    {
        public string data { get; set; }

        [JsonProperty("params")]
        public Param param { get; set; }


        public class Param
        {
            public string? datetime { get; set; }
            public string? newRichMenuAliasId { get; set; }
            public string? status { get; set; }
        }

    }
}
