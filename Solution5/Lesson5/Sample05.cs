using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Sample05
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("[A-Z]");
           Console.WriteLine(regex.IsMatch("Hello!"));
            Regex regex2 = new Regex("[A-Za-z]{3,9}");
            Console.WriteLine(regex2.IsMatch("Hello!"));
            Regex regex3 = new Regex("^[A-Za-z]{3,9}$");
            Console.WriteLine(regex3.IsMatch("Hello"));
            Regex regex4 = new Regex("^[0-9]{1,3}[A-Za-z]{3,9}$");
            Console.WriteLine(regex4.IsMatch("345Hello"));
            Console.ReadLine();
        }
    }
}
