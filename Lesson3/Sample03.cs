using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class ComplexClass
    {
        //Действительная часть комплексного числа
        private double re;
        //Мнимая часть комплексного числа
        private double im;

        //Свойство полей
        public double Re { 
            get { return re; } 
            set { re = value; } }
        public double Im { 
            get { return im; } 
            set { im = value; } }

        public ComplexClass() { }

        //Конструктор
        public ComplexClass(double re, double im) 
        {
            //таким образом мы даём понять компилятору , что наши поля лежат на самом классе
            //и инициализируем их
            if(im == 0)
            {
                throw new Exception("На ноль делить нельзя!");
            }
            this.re = re;
            this.im = im;
        }
        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x">Комплексное число</param>
        /// <returns>Резльтат сложения комплексных чисел</returns>
        public ComplexClass Plus(ComplexClass x)
        {
            ComplexClass complexres = new ComplexClass(re + x.re, im + x.im);
            //complexres.re = re + x.re;
            //complexres.im = im + x.im;
            return complexres;
        }
        public static ComplexClass Plus(ComplexClass a, ComplexClass b)
        {
            ComplexClass complexres = new ComplexClass(a.re + b.re, a.im + b.im);
            //complexres.re = a.re + b.re;
            //complexres.im = a.im + b.im;
            return complexres;
        }

        //переопределяем в методе ToString наши поля комплексного числа
        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
    internal class Sample03
    {
        static void Main(string[] args)
        {
            ComplexClass complex1 = new ComplexClass(5, -2);
            Console.Write(complex1.Re);
            //complex1.im = -2;

            ComplexClass complex2 = new ComplexClass(4, 3);
            //complex2.re = 4;
            //complex2.im = 3;
            ComplexClass complex3 = complex1.Plus(complex2);

            ComplexClass complex4 = ComplexClass.Plus(complex1, complex2);

            
            Console.WriteLine($"Результат сложения комплексных чмсел: {complex1} и {complex2} = {complex3}");
            Console.ReadLine();
        }
    }
}
