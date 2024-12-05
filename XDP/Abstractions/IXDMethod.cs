namespace XDP.Abstractions
{
    public interface IXDMethod : IXDMember
    {
        public string Returns { get; }

        public IEnumerable<IXDArgument> Arguments { get; }

        public IEnumerable<IXDException> Exceptions { get; }
    }
}
