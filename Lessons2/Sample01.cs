using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilis;

namespace Lessons2
{
    internal class Sample01
    {
        // static double x1, x2; // глобально (поле)
        static void Main(string[] args)
        {
            Outputhelpers.PrintInfo(2, "Щербаков Алескей Александрович");


            Console.WriteLine("Решение квадратного уравнения");
            Console.WriteLine("==============================");

            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение c: ");
            double c = double.Parse(Console.ReadLine());
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            double x1, x2; //локально

            if (discriminant < 0)
                Console.WriteLine("Квадратное уравнение не имеет корней");
            else
            {
                if (discriminant == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            Console.WriteLine("Нажмите Enter для продолжения.....");
            Console.ReadLine();

            Console.Clear();
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Тернарная операция");
            Console.WriteLine("Сравнение чисел");
            Console.WriteLine("===============");

            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());
            int maxNumber;
            maxNumber = number1 > number2 ? number1 : number2;
            Console.WriteLine($"Максимально число: {maxNumber}");
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
