using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons2
{
    internal class Sample02
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Циклы");
            Console.WriteLine("Цикл do while: ");
            Console.WriteLine("==================================");
            int a, counter = 0;
            do
            {
                Console.Write("Введите число от 0 до 100: ");
                a = int.Parse(Console.ReadLine());
                counter++;
            }
            while (a >= 0 && a <= 100);
            Console.WriteLine($"Вы совершили {counter} попыток ввода");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Цикл while: ");
            counter = 0;
            Console.WriteLine("Выводим сётчик, пока counter < 10");
            Console.WriteLine("==================================");
            while (counter < 10)
            {
                Console.Write($"{counter}\t");
                counter++;
            }
            Console.ReadLine();
            Console.Clear();

            //цикл for (инициализация; логическое условие; итерация);
            Console.WriteLine("Цикл for: ");
            Console.WriteLine("Выводим сётчик, пока i < 10");
            Console.WriteLine("==================================");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i}\t");
            }
            Console.ReadLine();
            Console.Clear();

            for (int i = 0, j = 10; i < j; i++, j--)
            {
                Console.WriteLine($"i - j: {i} - {j}");
            }
            Console.ReadLine();
        }
    }
}
