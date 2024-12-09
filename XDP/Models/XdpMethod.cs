using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using Xdp.Models.Parsing;

namespace Xdp.Models
{
    public class XdpMethod : XdpMember
    {
        public XdpString Returns { get; }

        public XdpParameter[] Parameters { get; }

        public string? TypeName { get; }

        public bool IsConstructor { get; }

        public XdpMethod(MethodInfo method, IEnumerable<XElement> referenceNodes, IEnumerable<Type> referenceTypes)
            : base(referenceNodes.GetMember($"{method.DeclaringType?.FullName}.{method.Name}", XdpMemberType.Method))
        {
            TypeName = method.ReturnType.FullName;

            Returns = new XdpString(Element.Element("returns"));

            var parameters = Element.Elements("param").ToArray();

            Parameters = new XdpParameter[parameters.Length];

            for (var i = 0; i < parameters.Length; i++)
            {
                var name = parameters[i].Attribute("name")?.Value ?? "";
                var parameter = method.GetParameters().FirstOrDefault(p => p.Name == name);
                if (parameter is null)
                {
                    Parameters[i] = new XdpParameter(parameters[i]);
                }
                else
                {
                    Parameters[i] = new XdpParameter(parameters[i]);
                }
            }
        }
    }
}
