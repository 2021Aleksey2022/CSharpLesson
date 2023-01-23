using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilis;

namespace Lesson3
{
    /*Структура (struct) в C# — это пользовательский тип данных, 
     * который используется наряду с классами и может содержать какие-либо данные и методы. 
     * Структурами также являются такие типы данных как int, double и т.д. 
     * Основное отличие структуры (struct) от класса (class) заключается в том, что структура — это тип значений, 
     * а класс — это ссылочный тип.    
     */
    //Структура описывает коплексное число
    struct Complex
    {
        //Действительная часть комплексного числа
        public double re;
        //Мнимая часть комплексного числа
        public double im;


        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x">Комплексное число</param>
        /// <returns>Резльтат сложения комплексных чисел</returns>
        public Complex Plus(Complex x)
        {
            Complex complexres;
            complexres.re = re + x.re;
            complexres.im = im + x.im;
            return complexres;
        }
        public static Complex Plus(Complex a, Complex b)
        {
            Complex complexres;
            complexres.re = a.re + b.re;
            complexres.im = a.im + b.im;
            return complexres;
        }

        //переопределяем в методе ToString наши поля комплексного числа
        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
    internal class Sample02
    {
        static void Main(string[] args)
        {
            Outputhelpers.PrintInfo(3, "Щербаков Алескй Александрович");
            int a = 1;
            char c = 'c';
            string s = "Hello!";
            bool b = true;
            Complex complex1;
            complex1.re = 5;
            complex1.im = -2;

            Complex complex2;
            complex2.re = 4;
            complex2.im = 3;
            Complex complex3 = complex1.Plus(complex2);

            Complex complex4 = Complex.Plus(complex1, complex2);

            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine($"Результат сложения комплексных чмсел: {complex1} и {complex2} = {complex3}");
            Console.ReadLine();
        }
        
    }
}
