using Business.Entities;
using System;

namespace Business
{
    class Program
    {
        static void Main(string[] args)
        {

            //Polimorfismo variaveis do mesmo tipo instanciados com objetos difrentes terao comportamento diferente.
            Account ac2 = new Account(02, "tais", 500);
            Account ac1 = new SavingsAccount(01, "diego", 500, 0.5);
            //account.Balance = 10;
            ac2.Withdraw(10);
            ac1.Withdraw(10);

            Console.WriteLine(ac2.Balance);
            Console.WriteLine(ac1.Balance);
            
        }
    }
}
