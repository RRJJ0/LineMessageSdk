using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Send.Message
{
    public class ImagemapMessage : Message
    {
        public override string type => "imagemap";
        public string baseUrl { get; set; }
        public string altText { get; set; }
        public BaseSize baseSize { get; set; }
        public Video video { get; set; }
        public List<Action> actions { get; set; }

        public class BaseSize
        {
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Video
        {
            public string originalContentUrl { get; set; }
            public string previewImageUrl { get; set; }
            public Area area { get; set; }
            public ExternalLink externalLink { get; set; }

        }

        public class Area
        {
            public int x { get; set; }
            public int y { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class ExternalLink
        {
            public string linkUri { get; set; }
            public string label { get; set; }
        }

        public abstract class Action
        {
            public abstract string type { get; }
            public Area area { get; set; }

        }

        public class UriAction : Action
        {
            public override string type => "uri";
            public string? label { get; set; }
            public string? linkUri { get; set; }
        }

        public class MessageAction : Action
        {
            public override string type => "message";
            public string? label { get; set; }
            public string text { get; set; }
        }

        public class ClipboardAction : Action
        {
            public override string type => "clipboard";
            public string? label { get; set; }
            public string clipboardText { get; set; }
        }
    }
}
