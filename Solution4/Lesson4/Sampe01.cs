using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Sampe01
    {
        /// <summary>
        /// Массивы
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Способы объявления массивов
            int[] arr;
            arr = new int[5];
            //Создали новый объект из 10 эл, а массив(объект) из 5 эл будет уничтожен, так ка на него 
            //не ссылается ни одна переменная
            arr = new int[10];

            int[] arr02 = new int[5];
            int[] arr03 = new int[] { 1, 4, -1, 0, 4 };
            int[] arr04 = { 1, -5, 4, 3 };

            //Обращаемся к массиву arr03 и к его элементу по индексу 3
            int e = arr03[3];
            //проходим по массиву с помощью цикла for
            for(int i = 0; i < 5; i++)
            {
                arr03[i] = arr03[i] * 2;
                Console.Write($"{arr03[i]}\t");
            }
            Console.WriteLine();
            int element = -2;
            int res = FindElement(arr03, element);
            Console.WriteLine("Элемент {0} {1}", element, res >= 0 ? $"найден по индексу {res}." : "не найде в массиве"); 

            Array.Sort(arr03);
            PrintArray(arr03);
            int res2 = Array.BinarySearch(arr03, element);
            Console.WriteLine("Элемент {0} {1}", element, res2 >= 0 ? $"найден по индексу {res2}." : "не найде в массиве");

            Console.ReadLine();
        }
        static int FindElement(int[] arr, int e)
        {
            for(int i = 0; i < arr.Length;i++)
            {
                //Проверием и Возвращаем значение если оно есть в массиве
                if (arr[i] == e)
                {
                    return i;
                }
            }
            //Вощрващаем -1, тем саммым говорим, что нет такого элемента в массиве
            return -1;
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
