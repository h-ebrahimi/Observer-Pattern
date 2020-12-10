using System;

namespace Observer_Pattern
{
    public class Account
    {
        private long _balance;
        public long Balance { get { return _balance; } private set { } }

        public event EventHandler<BalanceChangedEventArgs> BalanceChanged;

        public void Deposit(long amount)
        {
            if (amount > 0)
                _balance += amount;

            OnBalanceChanged(new BalanceChangedEventArgs(_balance));
        }

        public void Withdrew(long amount)
        {
            if (amount <= _balance)
                _balance -= amount;

            OnBalanceChanged(new BalanceChangedEventArgs(_balance));
        }

        private void OnBalanceChanged(BalanceChangedEventArgs e)
        {
            BalanceChanged?.Invoke(this, e);
        }
    }

    public class BalanceChangedEventArgs : EventArgs
    {
        public DateTime When { get; private set; }
        public long NewBalance { get; private set; }

        public BalanceChangedEventArgs(long newBalance)
        {
            When = DateTime.Now;
            NewBalance = newBalance;
        }
    }
    
    //Observers/Subscribers
    public class Emailer
    {
        public Emailer(Account account)
        {
            account.BalanceChanged += Account_BalanceChanged;
        }

        private void Account_BalanceChanged(object sender, BalanceChangedEventArgs e)
        {
            Console.WriteLine($"Sending Email => Changed Balance {e.NewBalance} at {e.When}");
        }
    }

    //Observers/Subscribers
    public class Logger
    {
        public Logger(Account account)
        {
            account.BalanceChanged += Account_BalanceChanged;
        }

        private void Account_BalanceChanged(object sender, BalanceChangedEventArgs e)
        {
            Console.WriteLine($"Logging => Changed Balance {e.NewBalance} at {e.When}");
        }
    }
}