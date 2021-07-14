using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities
{
    /******** SUPER CLASSE ***********/
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; } // pode ser alterado nas subclasse da heranca

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount) //sacar
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
