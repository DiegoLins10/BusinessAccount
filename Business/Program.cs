using Business.Entities;
using System;

namespace Business
{
    class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account(02, "tais", 500);
            Account ac1 = new SavingsAccount(01, "diego", 500, 0.5);
            //account.Balance = 10;
            account.Withdraw(10);
            ac1.Withdraw(10);

            Console.WriteLine(ac1.Balance);
            Console.WriteLine(account.Balance);
        }
    }
}
