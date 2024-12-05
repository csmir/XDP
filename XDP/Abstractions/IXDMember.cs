namespace XDP.Abstractions
{
    public interface IXDMember
    {
        public string Summary { get; }

        public string Remarks { get; }

        public string IsInherited { get; }
    }
}
