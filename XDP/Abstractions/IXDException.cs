namespace XDP.Abstractions
{
    public interface IXDException
    {
        public string Type { get; }

        public string Description { get; }
    }
}
