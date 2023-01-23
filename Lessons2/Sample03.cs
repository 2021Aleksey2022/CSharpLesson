using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons2
{
    internal class Sample03
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Оператор Switch");
            bool f = true;
            while (f)
            {
                Console.WriteLine("Мои Задачи: ");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача №1 ");
                Console.WriteLine("2 -> Задача №2 ");
                Console.WriteLine("3 -> Задача №3 ");
                Console.WriteLine("0 -> Завершение работы преложения");
                Console.WriteLine("=================================\n");
                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Tasck1();
                        break;
                    case 2:
                        Tasck2();
                        break;
                    case 3:
                        Tasck3();
                        break;
                    case 0:
                        Console.WriteLine("Завершение работы преложения");
                        Console.WriteLine("Нажмите на любкю клавишу....");
                        Console.ReadKey();
                        f = false;
                        break;
                    default:
                        Console.WriteLine("Вы вели некоректно номер задачи, пожалуйста повторите попытку ");
                        Console.ReadLine();
                        break;
                }
            }
        }
        static void Tasck1()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Выполнение задачи №1... ");
            Console.WriteLine("========================");
        }
        static void Tasck2()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Выполнение задачи №2... ");
            Console.WriteLine("========================");
        }
        static void Tasck3()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Выполнение задачи №3... ");
            Console.WriteLine("========================");
        }
    }
}

