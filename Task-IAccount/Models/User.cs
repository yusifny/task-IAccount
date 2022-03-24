using System;
namespace IAccount.Models
{
    interface IAccount
    {
        bool PasswordChecker(string pass);
        void ShowInfo();
    }
    internal class User : IAccount
    {
        private string _password;
        private static int count;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get { return _password; }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                    return;

                }
                Console.WriteLine("Invalid Password");

            }
        }

        internal static void PasswordChecker()
        {
            throw new NotImplementedException();
        }

        public User(string email, string password, string fullname)
        {
            Id = ++count;
            Email = email;
            Password = password;
            Fullname = fullname;
        }
        public bool PasswordChecker(string pass)
        {
            int count_1 = 0;
            int count_2 = 0;
            int count_3 = 0;
            if (pass.Length >= 8)
            {
                foreach (var item in pass)
                {
                    if (Char.IsUpper(item))
                    {
                        count_1++;
                    }
                    if (Char.IsLower(item))
                    {
                        count_2++;
                    }
                    if (Char.IsDigit(item))
                    {
                        count_3++;
                    }
                    if (count_1 > 0 && count_2 > 0 && count_3 > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} \nFullname: {Fullname} \nEmail: {Email}");
        }
    }
}