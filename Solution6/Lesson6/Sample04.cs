using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Sample04
    {
        static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
        static void Main(string[] args)
        {
            //Первый спсоб решения задачи
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 3, 9, -1, -4, 19, 8 });
            List<int> evenlist = new List<int>();
            foreach(int i in list)
            {
                if (IsEvenNumber(i))
                {
                    evenlist.Add(i);
                }               
            }
            foreach(int i in evenlist)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();

            //Второй способ решения задачи , с помошью делегата, FindAll - содержит в себе делегат
            evenlist = list.FindAll(IsEvenNumber);
            foreach (int i in evenlist)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            //третий способ решеня задачи, через анонимный метод
            evenlist = list.FindAll(delegate(int number) 
            {
                return number % 2 == 0;
            });
            foreach (int i in evenlist)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();

            //Четрвёртый способ решеня задачи, через анонимный метод и использования конструкции лямбда-выражения
            evenlist = list.FindAll(number => number % 2 == 0);
            foreach (int i in evenlist)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
