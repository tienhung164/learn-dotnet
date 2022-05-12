using System;

namespace day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("tienhung", "123");
            Account account1 = new Account();
            // account1.Input();
            // Console.WriteLine(account.Equal(account1));


            Customer customer = new Customer();
            customer.Input();
            customer.ToString();

        }
    }
}
