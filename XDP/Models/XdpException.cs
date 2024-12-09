using System.Xml;

namespace XDP.Models
{
    public class XdpException
    {
        public string Name { get; }

        public XdpString Description { get; }

        public Type Type { get; }

        public XdpException(Type exceptionType, XmlNode exceptionNode)
        {

        }
    }
}
