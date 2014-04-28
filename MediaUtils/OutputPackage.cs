using System.Drawing;
using System.IO;

namespace MediaUtils
{
    public class OutputPackage
    {
        public MemoryStream VideoStream { get; set; }
        public Image PreviewImage { get; set; }
        public string RawOutput { get; set; }
        public bool Success { get; set; }
    }
}