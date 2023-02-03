using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson6
{
    public static class DirFile
    {
        static XElement CreateFileSystemXmlTree(string source)
        {
            DirectoryInfo di = new DirectoryInfo(source);
            return new XElement("Dir",
                new XAttribute("Name", di.Name),
                from d in Directory.GetDirectories(source)
                select CreateFileSystemXmlTree(d),
                from fi in di.GetFiles()
                select new XElement("File",
                    new XElement("Name", fi.Name),
                    new XElement("Length", fi.Length)
                )
            );
        }

        static void Main(string[] args)
        {
            XElement fileSystemTree = CreateFileSystemXmlTree("C:\\Users\\manay\\Desktop\\CSharpLesson\\Solution6");
            Console.WriteLine(fileSystemTree);
            Console.WriteLine("------");
            long totalFileSize =
                (from f in fileSystemTree.Descendants("File")
                 select (long)f.Element("Length")).Sum();
            Console.WriteLine("Total File Size:{0}", totalFileSize);
            Console.ReadLine();
        }
    }
}
