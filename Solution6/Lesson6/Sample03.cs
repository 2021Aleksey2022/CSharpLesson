using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    //Описали делегат
    delegate double DoOperation(double x, double y);
    internal class Sample03
    {

        public static double Plus(double a, double b)
        {
            Console.Write($"{a} + {b}");
            return a + b;
        }
        public static double Minus(double a, double b)
        {
            Console.Write($"{a} - {b}");
            return a - b;
        }
        public static void Process(DoOperation operation, double x, double y)
        {
            Console.WriteLine($" = {operation(x, y)}");
        }
        /// <summary>
        /// Делегаты
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Инициализация делегата и передаём ссылку на метод Plus, теперь делегат будет ссылаться на метод Plus
            DoOperation doOperation = Plus;
            DoOperation doOperation2 = Minus;

            Process(doOperation, 10, 15);
            Process(Minus, 10, 15);
            //Анонимный метод
            DoOperation doOperation3 = delegate (double x, double y)
            {
                Console.Write($"{x} * {y}");
                return x * y;
            };
            Process(delegate (double x, double y)
            {

                Console.Write($"{x} / {y}");
                return x / y;
            }, 4, 4);

            Process(doOperation3, 4, 4);
            Console.ReadLine();
        }
    }
}
