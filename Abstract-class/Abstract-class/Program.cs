using Abstract_class.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Suppose that in a bank related business, only savings and business accounts are allowed. No common account.To ensure that common accounts
             *cannot be instantiated, we simply add the word "abstract" to the class statement.*/

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.0, 500.0));

            double sum = 0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Total Balance: U$ " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account: " + acc.Number + " : U$ " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
