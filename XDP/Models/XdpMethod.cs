using System.Xml;

namespace XDP.Models
{
    public class XdpMethod : XdpMember
    {
        public XdpString Returns { get; }

        public IEnumerable<XdpParameter> Parameters { get; }

        public Type? ReturnType { get; }

        public XdpMethod(Type returnType, XmlNode methodNode)
            : base(methodNode)
        {

        }
    }
}
