namespace Inheritance.Entities
{
    class BusinessAccount : Account  // BusinessAccount inherits from Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }
        public void loanLimit(double amount)
        {
            if (amount < LoanLimit)
                Balance += amount;
        }
    }
}
