using System.Xml.Linq;

namespace Xdp
{
    public readonly struct XdpString
    {
        public IEnumerable<XdpStringSegment> Segments { get; }

        public XdpString(XElement? element)
        {
            Segments = [];
        }
    }
}
