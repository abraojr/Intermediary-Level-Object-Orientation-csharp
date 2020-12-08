namespace Overlay_virtual_override_and_base_keywords.Entities
{
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

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        //When overlaying a method, we must include the prefix "override" in it 
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); // It is possible to call the implementation of the superclass using the base word.
            Balance -= 2.0;
        }
    }
}
