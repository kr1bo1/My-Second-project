using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Тема_2.Классы_и_методы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Sum() //1 метод
            {
                double num1 = Convert.ToDouble(Console.ReadLine()); //ввод первого числа
                double num2 = Convert.ToDouble(Console.ReadLine()); //ввод второго числа
                double rez = num1 + num2;
                Console.WriteLine(rez);
            }

            void Name() //2 метод
            { 
                String name = Convert.ToString(Console.ReadLine());
                Console.WriteLine(name +", you're very pretty)");
            }

            Console.WriteLine("Enter 2 numbers below and the program will display their sum");
            Sum();
            Console.WriteLine("Enter your name:");
            Name();

            Console.WriteLine("Enter your account login details:");
            User user = new User()
            {
                Name = "Maria",
                Surname = "Orlova",
                Password = "1234"
            };

            string login = Console.ReadLine();

            user.Check(login, "");

            Console.ReadLine();
            
        }
        public class User 
        {
            // Свойства
           public string Name; // Имя пользователя
           public string Surname; // Фамилия пользователя
           public string Password; // Пароль 
 
        public void Check(string name, string password) //метод для проверки данных
            {
                if (name == Name)
                {
                    Console.WriteLine("\r\nyou are logged in to your account!");
                }
                else
                {
                    Console.WriteLine("You entered the data incorrectly.");
                }
            }
        }
    }
}
