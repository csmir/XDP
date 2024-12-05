using XDP.Abstractions.Values;

namespace XDP.Models.Values
{
    public enum MarkupType
    {
        Regular,

        Bold,

        Italic,

        Underline
    }

    public class MarkupValue : IXDValue
    {
        public MarkupType MarkupType { get; } = MarkupType.Regular;

        public string Value { get; }

        public MarkupValue(MarkupType type, string value)
        {
            MarkupType = type;
            Value = value;
        }

        public string AsString()
        {
            return Value;
        }
    }
}
