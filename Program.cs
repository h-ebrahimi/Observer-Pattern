using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            var emailer = new Emailer(account);
            var logger = new Logger(account);

            account.Deposit(20);
            account.Deposit(10);
            account.Deposit(50);

            account.Withdrew(70);
            account.Deposit(23);
            account.Withdrew(17);

            Console.ReadLine();
        }
    }
}
