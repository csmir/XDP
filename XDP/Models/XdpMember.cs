using System.Xml;

namespace XDP.Models
{
    public class XdpMember
    {
        public string Name { get; }

        public XdpString Summary { get; }

        public XdpString Remarks { get; }

        public IEnumerable<XdpException> Exceptions { get; }

        public XdpMember(XmlNode memberNode)
        {
            Summary = memberNode.SelectSingleNode("summary")?.InnerText;
            Remarks = memberNode.SelectSingleNode("remarks")?.InnerText;
        }
    }
}
