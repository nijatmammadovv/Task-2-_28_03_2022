using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2__28_03_2022.Models
{
    class User : IAccount
    {
        private static int _id = 0;
        private string _password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Id { get; }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                    _password = value;
            }
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
            if (PasswordChecker(password))
                Id = _id;
            ++_id;
        }
        public User(string password, string fullname, string email) : this(password, email)
        {
            FullName = fullname;
        }
        /*
        - şifrədə minimum 8 character olmalıdır
        - şifrədə ən az 1 böyük hərf olmalıdır
        - şifrədə ən az 1 kiçik hərf olmalıdır
        - şifrədə ən az 1 rəqəm olmalıdır
        */
        public bool PasswordChecker(string password)
        {
            bool Number = false;
            bool Upper = false;
            bool Lower = false;
            char currentCharacter;

            if (!(password.Length >= 8))
            {
                return false;
            }

            for (int i = 0; i < password.Length; i++)
            {
                currentCharacter = password[i];
                if (char.IsDigit(currentCharacter))
                {
                    Number = true;
                }
                else if (char.IsUpper(currentCharacter))
                {
                    Upper = true;
                }
                else if (char.IsLower(currentCharacter))
                {
                    Lower = true;
                }

                if (Number && Upper && Lower)
                {
                    return true;
                }
            }
            return false;
        }
        //public void EmailChecker(string email)
        //{
        //    Console.WriteLine("Bir email daxil edin.");
        //    email = Convert.ToString(Console.ReadLine());
        //}
        //public void FullnameChecker(string fullname)
        //{
        //    Console.WriteLine("Bir ad soyad daxil edin.");
        //    fullname = Convert.ToString(Console.ReadLine());
        //}
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{_id}\n" +
               $" Email{Email}\n" +
               $" FullNAME{FullName}");
        }
        }
    }
