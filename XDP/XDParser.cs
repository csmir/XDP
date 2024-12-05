using System.Xml;

namespace XDP
{
    public class XDParser
    {
        private byte[] _data;

        public XDParser(string path)
        {
            var bytes = File.ReadAllBytes(path);

            _data = bytes;
        }

        public XDParser(byte[] bytes)
        {
            _data = bytes;
        }
    }
}
