using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Sample03
    {
        
        /// <summary>
        /// Двумерный массив
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            int[,] arr2 = { {1, 2, 1 }, {0, 9, 0 }, {2, 1, 7 } };
            int sum = 0;
            for(int i = 0; i < arr2.GetLength(0); i++)
            {
                for(int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write($"{arr2[i, j]}\t");
                    sum += arr2[i, j];
                }
                Console.WriteLine();
                Console.WriteLine("=======================================================");
            }
            Console.WriteLine($"Результат сложения всех элементов двумерного массива: {sum}");

            ////int j;
            //int[,] arr3 = new int[5, 5];
            //Random random = new Random();
            //for (int i = 0; i < arr3.GetLength(0); i++)
            //{

            //    for (int j = 0; j < arr3.GetLength(1); j++)
            //    {
            //        arr3[i, j] = random.Next(-99, 100);
            //        Console.Write($"{arr3[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            //int x = 0;
            //int y = 0;
            //int max = arr3[x, y];
            //for (int i = 0; i < arr3.GetLength(0); i++)
            //{

            //    for (int j = 0; j < arr3.GetLength(1); j++)
            //    {
            //        if (arr3[i,j] > max)
            //        {
            //            max = arr3[i,j];
            //            x = i;
            //            y = j;
            //        }
            //    }
            //}
            //Console.WriteLine($"Максимальное значение двумерного массива: {max}");
            //Console.WriteLine($"Расположенно по индексу [{x}, {y}]");
            //Console.WriteLine("-------------------------------------------------");
            //int x1 = 0;
            //int y1 = 0;
            //int max1 = arr3[x1, y1];
            //for (int a = 0; a < arr3.GetLength(0); a++)
            //{

            //    for (int b = 0; b < arr3.GetLength(1); b++)
            //    {
            //        if (arr3[a, b] < max1)
            //        {
            //            max1 = arr3[a, b];
            //            x1 = a;
            //            y1 = b;
            //        }
            //    }
            //}
            //Console.WriteLine($"Минимальное значение двумерного массива: {max1}");
            //Console.WriteLine($"Расположенно по индексу [{x1}, {y1}]");




            Console.ReadLine();
        }
    }
}
