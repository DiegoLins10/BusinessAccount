using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities
{
    /******** SUB CLASSE ***********/
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        BusinessAccount()
        {

        }

        /******** USANDO O REAPROVEITAMENTO DE CONSTRUTOR COM BASE ***********/
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
