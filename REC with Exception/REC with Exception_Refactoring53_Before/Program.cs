using System;

namespace Problem_ErrorCodeWithException
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account(100);
            int result = account.Withdraw(200);

            if (result == -1)
            {
                Console.WriteLine("Không đủ tiền trong tài khoản.");
            }
            else
            {
                Console.WriteLine("Rút tiền thành công.");
            }
        }
    }

    class Account
    {
        private int _balance;
        public Account(int balance) { _balance = balance; }
        public int Withdraw(int amount)
        {
            if (amount > _balance)
            {
                return -1; // Mã lỗi
            }
            _balance -= amount;
            return 0; // Thành công
        }
    }
}