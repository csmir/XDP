using System.Xml;

namespace XDP.Models
{
    public class XdpType
    {
        public string Name { get; }

        public string Summary { get; }

        public string Remarks { get; }

        public IEnumerable<XdpConstructor> Constructors { get; }

        public IEnumerable<XdpMethod> Methods { get; }

        public IEnumerable<XdpMember> Properties { get; }

        public IEnumerable<XdpMember> Fields { get; }

        public XdpType(Type type, XmlNode typeNode)
        {

        }
    }
}
