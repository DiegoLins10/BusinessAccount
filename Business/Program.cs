using Business.Entities;
using System;

namespace Business
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Account account = new Account();

            //account.Balance = 10;
            account.Deposit(1000);
            Console.WriteLine(account.Balance);
        }
    }
}
