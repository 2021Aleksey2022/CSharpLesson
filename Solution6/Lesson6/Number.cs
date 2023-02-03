using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Number
    {
        static void Main(string[] args)
        {
            Plus(10, 15);
        }
        public static double Plus(double a, double b)
        {
           
            Console.Write(a + b);
            Console.ReadLine();
            return a + b;
        }
    }
}
