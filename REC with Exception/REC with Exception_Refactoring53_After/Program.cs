using System;

namespace Solution_ErrorCodeWithException
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account(100);
            try
            {
                account.Withdraw(200);
                Console.WriteLine("Rút tiền thành công.");
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base("Không đủ tiền trong tài khoản.") { }
    }

    class Account
    {
        private int _balance;
        public Account(int balance) { _balance = balance; }
        public void Withdraw(int amount)
        {
            if (amount > _balance)
            {
                throw new InsufficientFundsException();
            }
            _balance -= amount;
        }
    }
}