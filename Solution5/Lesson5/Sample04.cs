using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Sample04
    {
        /// <summary>
        /// метод  StringBuilder
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //инициализыия класса StringBuilder
            string massage = "За окном потоп, а я ем торт.";
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder(massage);
            StringBuilder sb3 = new StringBuilder(1000);
            sb2.Append(" Очень холодно. ");
            sb2.Insert(3, "огромным ");
            sb2.Replace("торт", "бутерброд");
           

            Console.WriteLine(sb2.ToString());
            Console.ReadLine();
        }
    }
}
