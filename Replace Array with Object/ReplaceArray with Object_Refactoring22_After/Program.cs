using System;

namespace Solution_ReplaceArrayWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var performance = new Performance();
            performance.Name = "Liverpool";
            performance.Wins = 15;

            string name = performance.Name;
            int wins = performance.Wins;

            Console.WriteLine(name + " won " + wins + " games.");
        }
    }

    class Performance
    {
        public string Name { get; set; }
        public int Wins { get; set; }
    }
}