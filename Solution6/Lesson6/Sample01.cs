using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    /// <summary>
    /// Делегаты, файлы, коллекции
    /// </summary>
    internal class Sample01
    {
        static void PrintDir(DirectoryInfo dir, string indent, bool lastDir)
        {
            Console.Write(indent);
            if(lastDir)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "│";
            }
            Console.WriteLine(dir.Name);
            //file = dir.GetFiles();
            DirectoryInfo[] dirs = dir.GetDirectories();
            for(int i = 0; i < dirs.Length; i++)
            {
                PrintDir(dirs[i], indent, i == dirs.Length - 1);
                
            }
        }
        static void Main(string[] args)
        {
            // 4 вспомогательныйх  класса с работой файлами и директориями(папками), File, Directory, содержат статические методы,
            // а FileInfo, DirectoryInfno содержат не статические методы
            //Directory, File, DirectoryInfno, FileInfo

            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                Console.WriteLine($"FullName: {directoryInfo.FullName}");
                Console.WriteLine($"Name: {directoryInfo.Name}");
                Console.WriteLine($"Parent: {directoryInfo.Parent}");
                Console.WriteLine($"CreationTime: {directoryInfo.CreationTime}");
                Console.WriteLine($"Root: {directoryInfo.Root}");
            }
            Console.WriteLine();

            PrintDir(new DirectoryInfo("C:\\Users\\manay\\Desktop\\CSharpLesson\\Solution6"), "", true);

            Console.ReadLine();
        }
    }
}
