using System.Collections;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using Xdp.Models;

namespace Xdp
{
    public class XdpReader
    {
        public XdpReader()
        {
            
        }

        /// <summary>
        ///     Reads XML documentation from the output of a dotnet build process. This is the most common way to read Xdp
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public IEnumerable<XdpAssembly> FromBuild(string path)
        {
            var files = Directory.GetFiles(path, "*.xml", SearchOption.TopDirectoryOnly);

            var container = new XdpContainer();

            foreach (var file in files)
            {
                var info = new FileInfo(file);

                var asmDir = info.Directory!.FullName;
                var asmNam = info.Name.Replace(".xml", "");
                var asmFiles = Directory.GetFiles(asmDir, asmNam + ".*", SearchOption.TopDirectoryOnly);

                foreach (var asmFile in asmFiles)
                {
                    var reference = new XdpReference(asmNam);

                    try
                    {
                        reference.Assembly = Assembly.LoadFile(asmFile);

                        using var stream = File.OpenRead(info.FullName);

                        reference.Documentation = XElement.Load(stream);

                        stream.Close();
                    }
                    catch
                    {
                        continue;
                    }

                    container.References.Add(reference);
                }
            }

            var references = container.CrossMatchReferences();

            foreach (var reference in references)
            {
                yield return new XdpAssembly(reference);
            }
        }
    }
}
