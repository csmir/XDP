using XDP.Abstractions.Values;

namespace XDP.Models.Values
{
    public enum ReferenceType
    {
        Hypertext,

        Code,

        Langword,
    }

    public class ReferenceValue : IXDValue
    {
        public ReferenceType ReferenceType { get; set; }

        public string Value { get; }

        public ReferenceValue(ReferenceType type, string value)
        {
            ReferenceType = type;
            Value = value;
        }

        public string AsString()
        {
            return Value;
        }
    }
}
