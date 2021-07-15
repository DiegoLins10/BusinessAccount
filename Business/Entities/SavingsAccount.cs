
namespace Business.Entities
{
    /******** SUB CLASSE ***********/
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void  UpdateBalance()
        {
            Balance += InterestRate * InterestRate; // saldo vezes a taxa de juros
        }


        /******* SOBREPOSICAO OU SOBRESCRITA *********/
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
