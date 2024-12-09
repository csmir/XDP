using System.Xml;

namespace XDP.Models
{
    public class XdpConstructor : XdpMember
    {
        public IEnumerable<XdpParameter> Parameters { get; }

        public XdpConstructor(XmlNode constructorNode)
            : base(constructorNode)
        {

        }
    }
}
