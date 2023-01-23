using HomeWork2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Sample01 : DzSwitch
    {

        /// <summary>
        /// Модификаторы out, ref и метод TryParse.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Class1.OperatorSwitch();
            /*модификатор ref передаёт значение по ссылке, тобишь значение a, изменится на значение х
             * str - ссылочный тип, он содержит не значение , а ссылку на объект
             * TryParse - возвращает истину или ложь, проверяет на ввод данных пользователем
             * Модификатор out используется для возврата более одного значения из метода. 
             * Отличие out от ref состоит в том что передаваемую переменную не обязательно инициализировать
             *  Также метод объявленный с модификатором out обязан присвоить значение соответствующей переменной, 
             *  до своего завершения и передачи управления вызывающей функции.
             * 
             * 
             */
            int a = 10;
            int b = -5;
            int c = 1;
            string str = "Hello!";

            int a1;
            string str2;
            Sample("ddh", out a1, out str2);
            DoProcess(ref a, b, c, str);
            Console.Write("Введите целое число: ");
            int inputNumber = 1;
            if(int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.Write($"Вы ввели число: {inputNumber}\t");
                if (inputNumber < 10)
                    Console.WriteLine("Вы ввели число меньше 10");
                else
                {
                    Console.WriteLine("Вы ввели число больше чем 10");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число");
            }
            Console.ReadLine();
        }
        static void DoProcess(ref int x, int y, int z, string mystr)
        {
             x = 100;
             y = 100;
             z = 100;

        }
        static bool Sample(string s, out int a, out string str)
        {
            a = 10;
            str = "Hello!";
            return true;
        }
    }
}
