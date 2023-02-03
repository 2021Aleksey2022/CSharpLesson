using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class ВateOfBirth
    {     
        public void UsersNameOfSurname()
        {
            StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "UserList.txt");
            List<UserName> usersList1 = new List<UserName>();
            while (!streamReader.EndOfStream)
            {
                string[] parts = streamReader.ReadLine().Split(' ');
                UserName userName = new UserName();
                userName.Name = parts[1];
                userName.Surname = parts[0];
                userName.Birthday = DateTime.Parse(parts[2]);
                usersList1.Add(userName);
            }
            streamReader.Close();
            foreach (UserName userName in usersList1)
            {
                    Console.WriteLine($"{userName.Surname} {userName.Name} {userName.Birthday.ToShortDateString()}");
                
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            ВateOfBirth вateOfBirth = new ВateOfBirth();
            вateOfBirth.UsersNameOfSurname();
        }
    }
    class UserName
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
}
