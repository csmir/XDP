using System.Xml;

namespace XDP.Models
{
    public class XdpParameter
    {
        public string Name { get; }

        public bool IsOptional { get; }

        public XdpString Description { get; }

        public Type Type { get; }

        public XdpParameter(Type parameterType, XmlNode paramNode)
        {
            Description = paramNode.SelectSingleNode("description")?.InnerText;
        }
    }
}
