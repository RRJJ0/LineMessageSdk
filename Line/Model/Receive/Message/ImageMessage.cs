using Line.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.Receive.Message
{
    public class ImageMessage : Message
    {
        public MediaProvider contentProvider { get; set; }
        public ImageSet? imageSet { get; set; }
    }

    public class MediaProvider
    {
        public string type { get; set; }
        public string? originalContentUrl { get; set; }
        public string? previewImageUrl { get; set; }
    }

    public class ImageSet
    {
        public string? id { get; set; }
        public int? index { get; set; }
        public int? total { get; set; }
    }
}
