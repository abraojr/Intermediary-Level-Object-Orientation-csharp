using Inheritance.Entities;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Suppose a bank business that has a common account and a business account, and the business account has all members of the common account,
             *plus a loan limit and a loan operation.*/

            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //account.Balance = 200.0; // error
        }
    }
}
