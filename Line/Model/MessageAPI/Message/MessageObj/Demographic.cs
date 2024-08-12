using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Message.MessageObj
{
    public class Filter
    {
        public DemographicLogic demographicLogic {  get; set; }
    }

    public class DemographicLogic : Demographic
    {
        public override string type => "operator";

        public List<Demographic> and { get; set; }

        public List<Demographic> or { get; set; }

        public List<Demographic> not { get; set; }

    } 

    public abstract class Demographic
    {
        abstract public string type { get; }
    }

    public class Gender : Demographic
    {
        public override string type => "gender";

        public List<string> oneOf { get; set; }
    }

    public class Age : Demographic
    {
        public override string type => "age";

        public string gte { get; set; }

        public string lt { get; set; }
    }

    public class AppType : Demographic
    {
        public override string type => "appType";

        public List<string> oneOf { get; set; }
    }

    public class Area : Demographic
    {
        public override string type => "area";

        public List<string> oneOf { get; set; }
    }

    public class Friendship : Demographic
    {
        public override string type => "subscriptionPeriod";

        public string gte { get; set; }

        public string lt { get; set; }
    }
}
