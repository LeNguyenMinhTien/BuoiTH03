using System;

namespace Problem_RemoveSettingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account("ACC123");
            Console.WriteLine("Original ID: " + account.Id);

            account.Id = "ACC999"; // ID bị thay đổi một cách nguy hiểm
            Console.WriteLine("Changed ID: " + account.Id);
        }
    }

    class Account
    {
        public string Id { get; set; }
        public Account(string id) { Id = id; }
    }
}