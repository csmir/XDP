using XDP.Abstractions.Values;

namespace XDP.Models.Values
{
    public class NewlineValue : IXDValue
    {
        public string Value { get; }

        public NewlineValue()
        {
            Value = Environment.NewLine;
        }

        public string AsString()
        {
            return Value;
        }
    }
}
