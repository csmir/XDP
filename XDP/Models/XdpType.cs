using System.Reflection;
using System.Xml.Linq;
using Xdp.Models.Parsing;

namespace Xdp.Models
{
    public class XdpType : XdpElement
    {
        public string Name { get; }

        public XdpString Summary { get; }

        public XdpString Remarks { get; }

        public XdpMethod[] Methods { get; }

        public XdpMember[] Properties { get; }

        public XdpMember[] Fields { get; }

        public XdpType(Type type, IEnumerable<XElement> referenceNodes, IEnumerable<Type> referenceTypes)
            : base(referenceNodes.GetMember(type.FullName ?? type.Name, XdpMemberType.Type))
        {
            Name = type.FullName ?? type.Name;

            Summary = new XdpString(Element.Element("summary"));
            Remarks = new XdpString(Element.Element("remarks"));

            var methods = type.GetMethods(BindingFlags.Public);
            var props   = type.GetProperties(BindingFlags.Public);
            var fields  = type.GetFields(BindingFlags.Public);

            Methods     = new XdpMethod[methods.Length];
            Properties  = new XdpMember[methods.Length];
            Fields      = new XdpMember[methods.Length];

            for (var i = 0; i < methods.Length; i++)
                Methods[i] = new XdpMethod(methods[i], referenceNodes, referenceTypes);

            for (var i = 0; i < props.Length; i++)
                Properties[i] = new XdpMember(props[i], referenceNodes, referenceTypes);

            for (var i = 0; i < fields.Length; i++)
                Fields[i] = new XdpMember(fields[i], referenceNodes, referenceTypes);
        }
    }
}
