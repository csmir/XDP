using System.Xml.Linq;
using Xdp.Models.Parsing;

namespace Xdp
{
    internal static class Xtensions
    {
        private static readonly Dictionary<XdpMemberType, string> _memberTypeMatcher = new()
        {
            [XdpMemberType.Method] = "M:",
            [XdpMemberType.Property] = "P:",
            [XdpMemberType.Field] = "F:",
            [XdpMemberType.Type] = "T:",
        };

        public static XElement? GetMember(this IEnumerable<XElement> elements, string memberName, XdpMemberType memberType)
        {
            var realisticMemberName = _memberTypeMatcher[memberType] + memberName;

            return elements.Where(x => x.Attribute("name") is { } attribute && attribute.Value.StartsWith(realisticMemberName)).FirstOrDefault();
        }
    }
}
