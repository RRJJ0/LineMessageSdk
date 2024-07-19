using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message
{
    public class TemplateMessage : Message
    {
        public override string type => "template";
        public string altText { get; set; }
        public Template template { get; set; }

        public abstract class Template
        {
            public abstract string type { get; }
        }

        public class ButtonsTemplate : Template
        {
            public override string type => "buttons";
            public string? thumbnailImageUrl { get; set; }
            public string? imageAspectRatio { get; set; }
            public string? imageSize { get; set; }
            public string? imageBackgroundColor { get; set; }
            public string? title { get; set; }
            public string text { get; set; }
            public Action.Action? defaultAction {  get; set; }
            public List<Action.Action> actions {  get; set; }
        }

        public class ConfirmTemplate : Template
        {
            public override string type => "confirm";
            public string text { get; set; }
            public List<Action.Action> actions { get; set; }
        }

        public class CarouselTemplate : Template
        {
            public override string type => "carousel";
            public string? imageAspectRatio { get; set; }
            public string? imageSize { get; set; }
            public List<Column> columns { get; set; }

            public class Column
            {
                public string? thumbnailImageUrl { get; set; }
                public string? imageBackgroundColor { get; set; }
                public string? title { get; set; }
                public string text { get; set; }
                public Action.Action? defaultAction { get; set; }
                public List<Action.Action> actions { get; set; }
            }
        }

        public class ImageCarouselTemplate : Template
        {
            public override string type => "image_carousel";
            public List<Column> columns { get; set; }

            public class Column
            {
                public string imageUrl { get; set; }
                public Action.Action? action { get; set; }
            }
        }
    }
}
