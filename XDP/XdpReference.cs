using System.Reflection;
using System.Xml.Linq;

namespace Xdp
{
    public class XdpContainer
    {
        public List<XdpReference> References { get; } = [];

        public IEnumerable<XdpReference> CrossMatchReferences()
        {
            foreach (var reference in References)
            {
                reference.References = References.Where(x => x.Name != reference.Name);

                yield return reference;
            }
        }
    }

    public class XdpReference(string name)
    {
        public string Name { get; } = name;

        public Assembly Assembly { get; set; } = null!;

        public XElement Documentation { get; set; } = null!;

        public IEnumerable<XdpReference> References { get; set; } = [];
    }
}
