using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj
{
    public class RecipientLogic : Recipient
    {
        public override string type => "operator";

        public List<Recipient> and { get; set; }

        public List<Recipient> or { get; set; }

        public List<Recipient> not { get; set; }
        
    }

    public abstract class Recipient
    {
        abstract public string type { get; }
    }

    public class Audience : Recipient
    {
        public override string type => "audience";

        public long audienceGroupId { get; set; }
    }

    public class Redelivery : Recipient
    {
        public override string type => "redelivery";

        public string requestId { get; set; }
    }
}
