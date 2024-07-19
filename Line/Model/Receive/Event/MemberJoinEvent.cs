using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Event
{
    public class MemberJoinEvent : Event
    {
        public MemberAction joined { get; set; }
    }

    public class MemberAction
    {
        public List<Member> members { get; set; }
    }

    public class Member
    {
        public string type { get; set; }
        public string userId { get; set; }
    }
}
