using Line.Model.Send.Message.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message
{
    public class FlexMessage : Message
    {
        public override string type => "flex";
        public string altText { get; set; }
        // public contents {


        public abstract class Container
        {
            public abstract string type { get; }
        }

        public class BubbleConatiner : Container
        {
            public override string type => "bubble";
            public string? size { get; set; }
            public string? direction { get; set; }
            public Component.Box? header { get; set; }
            public Component.HeroComponent? hero { get; set; }
            public Component.Box? body { get; set; }
            public Component.Box? footer { get; set; }
            public Style? styles { get; set; }
            public Action.Action? action { get; set; }


            public class Size
            {
                public const string nano = "nano";
                public const string micro = "micro";
                public const string deca = "deca";
                public const string hecto = "hecto";
                public const string kilo = "kilo";
                public const string mega = "mega";
                public const string giga = "giga";
            }

            public class Direction
            {
                public const string nano = "ltr";
                public const string micro = "rtl"; 
            }

            public class Style
            {
                public BlockStyle? header { get; set; }
                public BlockStyle? hero { get; set; }
                public BlockStyle? body { get; set; }
                public BlockStyle? footer { get; set; }
            }
        }

        public class BlockStyle
        {
            public string? backgroundColor { get; set; }
            public bool? separator { get; set; }
            public string? separatorColor { get; set; }
        }

        public class CarouselContainer : Container
        {
            public override string type => "carousel";
            public List<BubbleConatiner> contents { get; set; }
        }
    }
}
