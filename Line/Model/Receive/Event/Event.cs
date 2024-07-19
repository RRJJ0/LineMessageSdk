using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Event
{
    public class Event
    {
        public string type { get; set; }
        public long timestamp { get; set; }
        public Source? source { get; set; }
        public string mode { get; set; }
        public string webhookEventId { get; set; }
        public DeliveryContext deliveryContext { get; set; }
        public string? replyToken { get; set; }


        public class DeliveryContext
        {
            public bool isRedelivery { get; set; }
        }

        public class Source
        {
            public string type { get; set; }
            public string? groupId { get; set; }
            public string? roomId { get; set; }
            public string userId { get; set; }
        }
    }
}
