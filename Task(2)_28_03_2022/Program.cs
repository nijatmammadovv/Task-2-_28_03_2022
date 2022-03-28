using System;
using Task_2__28_03_2022.Models;

namespace Task_2__28_03_2022
{
     class Program
    {
        static void Main(string[] args)
        {
            string fullname = " ";
            string email    = " ";
            string password = " ";
            User[] users = new User[0];

            int choice = 0;
            do
            {
                Start:
                try
                {
                    Console.WriteLine("Choose the command (0:Info)");
                    Console.WriteLine("--------------");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You can use it to get information!");
                    goto Start;
                }
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("----------------");
                        Console.WriteLine("1:Create an account\n" +
                            "2:ShowInfo\n" +
                            "3:Exit the program");
                        Console.WriteLine("----------------");
                        break;
                    case 1:
                        Console.WriteLine("----------------");
                        Array.Resize(ref users, users.Length + 1);
                        users[users.Length-1] = new User(password, fullname, email);
                        UserInformation(ref fullname, ref email, ref password);
                        Console.WriteLine("----------------");
                        break;
                    case 2:
                         foreach (var user in users)
                            user.ShowInfo();
                        break;
                    default:
                        Console.WriteLine("-----------------");
                        Console.WriteLine("User account information was entered incorrectly.");
                        Console.WriteLine("-----------------");
                        break;
                }
            } while (choice != 2);
        }

        static void UserInformation(ref string fullname, ref string email, ref string password)
        {
            FullName(ref fullname);
            Email(ref email);
            Password(ref password);
        }
        static void FullName(ref string fullname)
        {
            Begin:
            try
            {
                Console.WriteLine("Enter the person's name");
                fullname = Convert.ToString(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Begin;
            }
        }
        static void Email(ref string email)
        {
            Initiate:
            try
            {
                Console.WriteLine("Enter the person's email");
                email = Convert.ToString(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Initiate;
            }
        }
        static void Password(ref string password)
        {
            GetStarted:
            try
            {
                Console.WriteLine("Enter the person's password");
                password = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto GetStarted;
            }
        }
    }
}
