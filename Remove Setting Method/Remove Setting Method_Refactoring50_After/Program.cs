using System;

namespace Solution_RemoveSettingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account("ACC123");
            Console.WriteLine("Original ID: " + account.Id);

            // account.Id = "ACC999"; // Dòng này sẽ gây lỗi biên dịch!
        }
    }

    class Account
    {
        public string Id { get; private set; }
        public Account(string id) { Id = id; }
    }
}