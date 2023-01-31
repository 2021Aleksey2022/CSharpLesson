using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Sample01
    {
        /// <summary>
        /// Символьный тип char
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char[] chars = new char[]
            {
                'j',
                '\u006A',
                (char)106,
                '\u005A',
                (char)90,
                '\u076B'
            };
            char b = 'B';
            Console.WriteLine($"{b} : {char.ToLower(b)}");
            Console.WriteLine(string.Join(" ", chars));
            Console.ReadLine();

            char c = '¾';
            Console.WriteLine(char.GetNumericValue(c)); 
            Console.ReadLine();

            char[] arr = new char[] { '1', 's', '$', 'M', '+' };
            for(int i = 0; i < arr.Length; i++)
            {
                UnicodeCategory unicodeCategory =  char.GetUnicodeCategory(arr[i]);
                switch(unicodeCategory)
                {
                    case UnicodeCategory.UppercaseLetter:
                        Console.WriteLine($"{arr[i]}: Символ в верхнем регистре");
                        break;
                    case UnicodeCategory.LowercaseLetter:
                        Console.WriteLine($"{arr[i]}: Символ в нижнем регистре");
                        break;
                    case UnicodeCategory.DecimalDigitNumber:
                        Console.WriteLine($"{arr[i]}: число");
                        break;
                    case UnicodeCategory.MathSymbol:
                        Console.WriteLine($"{arr[i]}: математический символ");
                        break;
                    default:
                        Console.WriteLine($"{arr[i]}: Другое......");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
