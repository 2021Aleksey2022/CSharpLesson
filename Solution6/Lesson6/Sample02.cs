using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
    internal class Sample02
    {
        static void Main(string[] args)
        {
            //Необобщённая коллекция, обёртка над массивом
            ArrayList arrayList = new ArrayList();
            //Считываем информацию с файла
            StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UserList.txt");
            while (!streamReader.EndOfStream)
            {
                string[] parts = streamReader.ReadLine().Split(' ');
                User user = new User();
                user.Name = parts[1];
                user.Surname = parts[0];
                user.Birthday = DateTime.Parse(parts[2]);
                arrayList.Add(user);
            }
            streamReader.Close();
            arrayList.Add(1);
            arrayList.Add(true);
            arrayList.Add("Hello, World!");
            foreach (object user in arrayList)
            {
                if (user is User)
                {
                    Console.WriteLine($"{((User)user).Surname} {((User)user).Name} {((User)user).Birthday.ToShortDateString()}");

                }
            }
            Console.ReadLine();
            MyList<int> myList = new MyList<int>();
            myList.Insert(0, 1);
            //Обобщённая коллекция
            List<User> usersList = new List<User>();
            streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UserList.txt");
            while (!streamReader.EndOfStream)
            {
                string[] parts = streamReader.ReadLine().Split(' ');
                User user = new User();
                user.Name = parts[1];
                user.Surname = parts[0];
                user.Birthday = DateTime.Parse(parts[2]);
                usersList.Add(user);
            }
            streamReader.Close();
            foreach (User user in usersList)
            {                               
             Console.WriteLine($"{user.Surname} {user.Name} {user.Birthday.ToShortDateString()}");                
            }
            Console.ReadLine();
        }
    }
    //<T> - это универсальный параметр, через который будем обращаться к методом, свойствам. полям и.т.д
    class MyList<T>
    {
        T[] array;

        public int Lenght
        {
            get { return array.Length; }
        }
        public MyList()
        {
            array = new T[16];
        }
        public void Insert(int i, T e)
        {
            array[i] = e;
        }
    }
}
