using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Event
{
    public class FollowEvent : Event
    {
        public Follow follow { get; set; }
    }

    public class Follow
    {
        public bool isUnblocked { get; set; }
    }
}
