using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Event
{
    public class AccountLinkEvent : Event
    {
        public AccountLink? accountLink { get; set; }
    }

    public class AccountLink
    {
        public string result { get; set; }
        public string nonce { get; set; }
    }
}
