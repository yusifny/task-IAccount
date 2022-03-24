using System;
using IAccount.Models;
namespace IAccount
{
    internal class Program
    {
        private static string password;

        static void Main(string[] args)
        {

            Console.Write("Email:");
            string Email = Console.ReadLine();

            Console.Write("Fullname:");
            string Fullname = Console.ReadLine();
            bool check = true;
            do
            {

                Console.Write("Password:");
                string password = Console.ReadLine();
                User user = new User(Email, password, Fullname);

                if (user.PasswordChecker(password))
                {
                    check = false;
                }
            } while (check);            
        }
    }
}