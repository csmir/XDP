using System.Xml;
using System.Xml.Linq;

namespace Xdp.Models
{
    public class XdpException : XdpElement
    {
        public string Name { get; }

        public XdpString Description { get; }

        public XdpException(XElement? element)
            : base(element)
        {
            Name = Element.Attribute("cref")!.Value[2..];
            Description = new XdpString(element);
        }
    }
}
