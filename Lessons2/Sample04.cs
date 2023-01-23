using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons2
{
    internal class Sample04
    {
        static void f(int n)
        {
            Console.WriteLine(n);
            if (n >= 3)
            {
                f(n - 1);
                f(n - 2);
                f(n - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Рекурсия");
            f(4);
            Console.ReadLine();
        }
    }
}
