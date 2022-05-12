using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Account()
        {
        }

        public void ToString()
        {
            Console.WriteLine($" username: {Username},password: {Password}");
        }

        public void Input()
        {
            Console.WriteLine("nhap username");
            Username = Console.ReadLine();
            Console.WriteLine("nhap  passwprd");
            Password = Console.ReadLine();
        }
        public bool Equal(Account input)
        {
            if (Password != input.Password || Username != input.Username)
                return false;

            return true;
        }

    }


    public class Customer : Account
    {
        public string DOB { get; set; }
        public string Name { get; set; }

        public Customer(string username, string password, string dOB, string name) : base(username, password)
        {


            DOB = dOB;
            Name = name;

        }

        public Customer()
        {



        }


        public void ToString()
        {
            base.ToString();
            Console.WriteLine($"dob: {DOB}, Name: {Name}");
        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("nhap DOB");
            DOB = Console.ReadLine();
            Console.WriteLine("nhap  Name");
            Name = Console.ReadLine();

        }
    }

}