using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public static class Massage
    {
        private static string[] seperator = { ",", ".", "!", "?", ";", ":", " ", "-" };
        public static void PrintWords(string massage)
        {
            string[] words = massage.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5 && words[i][0].Equals(words[i][words[i].Length - 1])) 
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
    internal class Sample03
    {
        static void Main(string[] args)
        {
            string massage = "За окном потоп, а я ем торт.";
            Massage.PrintWords(massage);
            Console.ReadLine();
        }
    }
}
