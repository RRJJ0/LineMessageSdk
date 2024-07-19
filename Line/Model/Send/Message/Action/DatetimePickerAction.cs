using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message.Action
{
    public class DatetimePickerAction : Action
    {
        public override string type => "datetimepicker";
        public string? label { get; set; }
        public string data { get; set; }
        public string mode { get; set; }
        public string? initial { get; set; }
        public string? max { get; set; }
        public string? min { get; set; }
        //date format
        // yyyy-MM-dd
        // HH:mm
        // yyyy-MM-ddTHH:mm

        public class Mode
        {
            public const string date = "date";
            public const string time = "time";
            public const string datetime = "datetime";
        }
    }


}
