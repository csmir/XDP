using System.Xml;
using System.Xml.Linq;

namespace Xdp.Models
{
    public class XdpElement
    {
        public XElement Element { get; }

        public XdpElement(XElement? element)
        {
            if (element == null)
                throw new XmlException("Member element is null.");

            Element = element;
        }
    }
}
