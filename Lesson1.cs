using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress
{
    internal class Lesson1
    {
        //Перегрузка метода , это когда несколько методов с одним именем , но разными параметрами
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            string number1 = Console.ReadLine();
            int x = int.Parse(number1);
            Console.Write("Введите второе число: ");
            string number2 = Console.ReadLine();
            int y = int.Parse(number2);
            int res01 = SumNumber(x, y, 10);
            Console.WriteLine($"Складывем числа: {x} + {y} + {10}");
            Console.WriteLine($"Результат сложения: {res01} ");
            Console.ReadLine();
        }
        static int SumNumber(int a, int b)
        {
          int res = a + b;
            return res;
        }
        static int SumNumber(int a, int b, int c)
        {
            int res = a + b + c;
            return res;
        }


    }
}
