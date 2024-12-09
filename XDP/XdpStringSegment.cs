namespace Xdp
{
    public enum SegmentMarkup
    {
        Normal,

        Italic,

        Bold,

        Newline
    }

    public readonly struct XdpStringSegment
    {
        public SegmentMarkup Markup { get; }

        public string Text { get; }

        public XdpStringSegment(string segment)
        {
            Markup = SegmentMarkup.Normal;
            Text = segment;
        }

        public XdpStringSegment(string segment, SegmentMarkup markup)
        {
            Markup = markup;
            Text = segment;
        }
    }
}
