using System.Reflection;

namespace XDP
{
    public class XdpContainer
    {
        public List<XdpReference> References { get; } = [];
    }

    public class XdpReference
    {
        public string Name { get; }

        public Assembly? Assembly { get; set; } = null;

        public byte[] Documentation { get; set; } = [];

        public XdpReference[] References { get; set; } = [];

        public XdpReference(string name)
        {
            Name = name;
        }

        public XdpReference AttachReferences(IEnumerable<XdpReference> references)
        {
            References = references.Where(x => x.Name != Name).ToArray();

            return this;
        }
    }
}
