using System.Xml.Linq;

namespace Xdp.Models
{
    public class XdpAssembly : XdpElement
    {
        public string? Name { get; }

        public XdpType[] Types { get; }

        public XdpAssembly(XdpReference reference)
            : base(reference.Documentation.Elements("doc").FirstOrDefault())
        {
            var members = Element.Elements();
            var referenceMembers = reference.References
                .SelectMany(x => x.Documentation
                    .Elements("doc")
                    .Elements("member"))
                .Concat(members.Where(x => x.Name == "members"));

            var types = reference.Assembly.GetExportedTypes();
            var referenceTypes = reference.References
                .SelectMany(x => x.Assembly.GetExportedTypes())
                .Concat(types);

            Name = members
                .Elements("assembly")
                .Elements("name")
                .Select(x => x.Value)
                .FirstOrDefault();

            Types = new XdpType[types.Length];

            for (var i = 0; i < types.Length; i++)
                Types[i] = new XdpType(types[i], referenceMembers, referenceTypes);
        }
    }
}
