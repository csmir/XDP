using System.Xml.Linq;

namespace Xdp.Models
{
    public class XdpParameter : XdpElement
    {
        public string Name { get; }

        public string? TypeName { get; }

        public XdpString Description { get; }

        public XdpParameter(XElement? element, string? typeName)
            : base(element)
        {
            TypeName = typeName;

            Name = Element.Attribute("name")!.Value;
            Description = new XdpString(element);
        }
    }
}
