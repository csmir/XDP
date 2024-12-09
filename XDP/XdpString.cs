namespace XDP
{
    public readonly struct XdpString
    {
        public IEnumerable<XdpStringSegment> Segments { get; }

        public XdpString(IEnumerable<XdpStringSegment> segments)
        {
            Segments = segments;
        }

        public static XdpString Read(string stringData)
        {
            // parse

            return new XdpString([]);
        }
    }
}
