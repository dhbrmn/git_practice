using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string password;


        private string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length >= 8)
                {
                    password = value;
                }
            }
        }

        public bool IsChanged
        { get; private set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
                Password = password;
                Hidden = hidden;           
        }

        public string HeaderSymbol
        { get { return "-----------"; } }


        public void Display()
        {
            Console.WriteLine("Password:");
            Console.WriteLine($"{HeaderSymbol}");
            if (Hidden == true)
            {
                Console.WriteLine("******");
            }
            else
            {
                Console.WriteLine(Password);
            }
        }

        public void Reset()
        {
            Password = null;
            Hidden = false;
        }

        public void ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == Password)
            {
                Password = newPassword;
                IsChanged = true;
                Console.WriteLine("Password changed successfully");
            }
            else
            {
                Console.WriteLine("Current passwords don't match.");
            }
        }
    }
}