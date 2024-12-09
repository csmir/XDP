using System.Xml.Linq;

namespace Xdp.Models
{
    public class XdpMember : XdpElement
    {
        public string? Name { get; }

        public XdpString Summary { get; }

        public XdpString Remarks { get; }

        public XdpException[] Exceptions { get; }

        public XdpMember(XElement? element)
            : base(element)
        {
            Name = Element.Attribute("name")?.Value;

            Summary = new XdpString(Element.Element("summary"));
            Remarks = new XdpString(Element.Element("remarks"));

            var exceptions = Element.Elements("exception").ToArray();

            Exceptions = new XdpException[exceptions.Length];

            for (var i = 0; i < exceptions.Length; i++)
                Exceptions[i] = new XdpException(exceptions[i]);
        }
    }
}
