using Overlay_virtual_override_and_base_keywords.Entities;
using System;

namespace Overlay_virtual_override_and_base_keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Suppose a bank business that has a common account and a business account, and the business account has all members of the common account,
           *plus a loan limit and a loan operation.
            Suppose the following rules for withdraw:
            - Common account: is charged a fee of 5.00.
            - Savings account: make the withdrawal normally from the superclass (Account), and then discount another 2.0..*/

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance); //OUTPUT: 485
            Console.WriteLine(acc2.Balance); //OUTPUT: 483
        }
    }
}
