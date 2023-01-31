using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Sample02
    {
        /// <summary>
        /// Сравнение строк , метод Equals
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string str = "using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading.Tasks; ";
            Console.WriteLine(str);
            Console.ReadLine();
            string s1 = "Hello, GekBrains";
            string s2 = "Hello, GekBrains";
            MyString myString = new MyString(new char[] { 'H', 'e', 'l', 'l', 'o' });
            MyString myString1 = new MyString(new char[] { 'H', 'e', 'r', 'r', 'o', 'b' });

            //пытаемся сравнить строки равны они или нет , получаем false, так как две строки ссылаются на два разных объекта
            Console.WriteLine(myString.Equals(myString1));
            //Console.WriteLine(myString == myString1);
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1 == s2);

            Console.ReadLine();
        }
        
    }
     public class MyString
     {
        private char[] chars;
        public int I
        {
            get { return 5; }
        }
        public MyString(char[] chars)
        {
            this.chars = chars;
        }
        public override bool Equals(object obj)
        {
            if(obj is MyString)
            {
                return I == ((MyString)obj).I;
            }
            return false;
        }
    }
}
