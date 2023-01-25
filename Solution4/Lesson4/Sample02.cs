using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class MyArray
    {
        private int[] arr;

        public int this[int index]
        {
            get
            {
                return index;
            }
            set
            {
                arr[index] = value;
            }
        }
        public MyArray(int count)
        {
            Random random = new Random();
            this.arr = new int[count];
            for(int i = 0; i < count; i++)
            {
                this.arr[i] = random.Next(-99, 100);
            }
            
        }


        //Конструктор
        public MyArray(int[] arr)
        {
            //Прежде чем копировать массив, его нужно проинициализировать
            this.arr = new int[arr.Length];
            Array.Copy(arr, this.arr, arr.Length);
        }
        public MyArray(string fileName)
        {
            this.arr = LoadArrayromFile(fileName);
        }
        private int[] LoadArrayromFile(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException("Такого файла не существует");
            int[] buf = new int[1000];
            int counter = 0;

            //Запись файла
            //StreamWriter streamWriter = new StreamWriter(fileName);
            //streamWriter.WriteLine();

            //чтение файла
            StreamReader streamReader = new StreamReader(fileName);

            while (!streamReader.EndOfStream)
            {
               buf[counter] = int.Parse(streamReader.ReadLine());
                counter++;
            }
            streamReader.Close();
            int[] arr = new int[counter];
            Array.Copy(buf, arr, counter);
            return arr;

            
        }
        public void PrintArray()
        {
            //Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }
    }
    internal class Sample02
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, -5, 4, 0 };
            //передаём параметр arr из конструктора, котрого создали ранее
            MyArray myArray = new MyArray(arr);
            myArray.PrintArray();

            myArray = new MyArray(AppDomain.CurrentDomain.BaseDirectory + "ArrayList1.txt");
            myArray.PrintArray();

            myArray = new MyArray(20);
            myArray.PrintArray();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
